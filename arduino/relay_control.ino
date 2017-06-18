int M_P[7] = {13,12,11,10,9,8,7};
boolean loadopen[5] = {false,false,false,false,false};
char cmd;
void setup()
{
  // define the PIN as OUTPUT 
  for(int i = 0;i<7;i++){
    pinMode(M_P[i],OUTPUT);
  }
  
  // set baud rate 9600
  Serial.begin(9600);
}

void loop()
{
  while (Serial.available()) //connected
  { 
      cmd = Serial.read();
      
      switch(cmd){
        case '0' :
          for(int i = 0; i<5; i++){
            digitalWrite(M_P[i],0);
            loadopen[i] = false;
          }
          Serial.print("2");
          break;  
        case '1' :
          if(loadopen[cmd-49] == false){
            loadopen[cmd-49] = true;
            digitalWrite(M_P[cmd-49],1);
            Serial.print("1");
          }else if(loadopen[cmd-49] == true){
            loadopen[cmd-49] = false;
            digitalWrite(M_P[cmd-49],0);
            Serial.print("0");
          }
          break;
        case '2' :
          if(loadopen[cmd-49] == false){
            loadopen[cmd-49] = true;
            digitalWrite(M_P[cmd-49],1);
            Serial.print("1");
          }else if(loadopen[cmd-49] == true){
            loadopen[cmd-49] = false;
            digitalWrite(M_P[cmd-49],0);
            Serial.print("0");
          }
          break;
        case '3' :
          if(loadopen[cmd-49] == false){
            loadopen[cmd-49] = true;
            digitalWrite(M_P[cmd-49],1);
            Serial.print("1");
          }else if(loadopen[cmd-49] == true){
            loadopen[cmd-49] = false;
            digitalWrite(M_P[cmd-49],0);
            Serial.print("0");
          }
          break;
        case '4' :
          if(loadopen[cmd-49] == false){
            loadopen[cmd-49] = true;
            digitalWrite(M_P[cmd-49],1);
            Serial.print("1");
          }else if(loadopen[cmd-49] == true){
            loadopen[cmd-49] = false;
            digitalWrite(M_P[cmd-49],0);
            Serial.print("0");
          }
          break;
        case '5' :
          if(loadopen[cmd-49] == false){
            loadopen[cmd-49] = true;
            digitalWrite(M_P[cmd-49],1);
            Serial.print("1");
          }else if(loadopen[cmd-49] == true){
            loadopen[cmd-49] = false;
            digitalWrite(M_P[cmd-49],0);
            Serial.print("0");
          }
          break;
      }
  }
}

