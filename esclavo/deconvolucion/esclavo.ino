#include <SoftwareSerial.h>

SoftwareSerial mySerial(10, 11); // RX, TX

String DATO;

void setup() {
  
  Serial.begin(9600);
  mySerial.begin(9600);
  
 
}

void loop() { // run over and over

  if(mySerial.available()>0)
  {
    Serial.write(mySerial.read());
  }
    
   
  
  }
