    #include <SoftwareSerial.h>

    int in_rf;
    char in_rs;  
    String rs, rf, num;
    float tm, tmm;

    SoftwareSerial RS485(3, 4); // RX, TX
    SoftwareSerial RDM6300(6, 7); // RX, TX
    
    void setup()
     {
      Serial.flush();   // Очищаем буфер
      Serial.begin(9600);  // Устанавливаем скорость работы с COM портом
      RDM6300.begin(9600);  // инициализируем RDM630 на скорости 9600
      rf="";
      tmm=millis();
      pinMode(9, OUTPUT);
      num="413";      //  3 любых символа - идентификатор замка
     }

    String INRS ()   // модуль получения данных через RS485
    {
      while (RS485.available() > 0)
       {
        in_rs = RS485.read(); // читаем блок данных с модуля RS485 и заносим их в переменную input
        rs+=in_rs;  // то же самое, что и s=s+input;
        delay (10);  // небольшая задержка с учетом скорости работы RS485
       }
       return (rs);
    }


    String RFID ()      // модуль получения данных из RFID
      {
       delay (20);
       for (int i=1; i<=14; i++)  // 14 блоков данных
        {
          in_rf = RDM6300.read();     // читаем блок данных с модуля RDM630 и заносим их в переменную input
          rf+=in_rf;      // присваиваем все считанные в переменную input значения переменной s, так как за 1 цикл loop мы получаем 1 значение, а их 12
        }
       RDM6300.flush();    //очищаем буфер RDM6300
       return (rf);
    }
  
    void loop()
    {
      delay (100);
      if (RDM6300.available() > 0 && (tmm+2000)<millis()) // если есть данные RFID и прошло 2 сек.
        {  
         rf= RFID ();
         RDM6300.end();
         delay (100);
         RS485.begin(9600);
         RS485.println (num+","+rf);
         Serial.println("Otpravleno: "+rf);      // выводим данные
         tm = millis();
         while ((tm+1000) > millis())  //Ожидание ответа 1 с
         {
          if (RS485.available() > 0) // если есть данные RS485, то 
           {
            rs=INRS();  //Читаем данные из RS485
            Serial.println("Polucheno "+rs);      // выводим данные
             if (rs.substring(0,8).equals(num+",open"))  //если пришла команда на открытие
              {
               Serial.println("otkrivaem zamok");
               digitalWrite(9, HIGH);   // открываем замок
               delay(3000);              // ждем 3 секунды
               digitalWrite(9, LOW);    // закрываем замок
              }
            
            rs="";  // очищаем переменную
           }
         }
         RS485.end();
         rf="";      // очищаем переменную для RFID
         tmm=millis();
         RDM6300.begin(9600);  // инициализируем RDM630 на скорости 9600
       }
    }

