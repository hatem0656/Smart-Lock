

#define motor_pin1 3
#define motor_pin2 4
#define motor_pwm 5
#define proximity 6
#define Red_Led 8
#define Green_Led 9

bool connection = false ;
String data = "", password = "1234" , state = "start";
char x  ;
void setup()
{
  Serial.begin(9600) ;

  pinMode(proximity, INPUT) ;
  pinMode(Red_Led , OUTPUT);
  pinMode(Green_Led , OUTPUT);
  pinMode(motor_pin1 , OUTPUT);
  pinMode(motor_pin2 , OUTPUT);
  digitalWrite(Red_Led , HIGH);
  digitalWrite(Green_Led , LOW);
  digitalWrite(motor_pin1, LOW);
  digitalWrite(motor_pin2, LOW);


}

void loop()
{
  if ( digitalRead(proximity) == LOW ) // a person in front of the lock
  {
    if (state == "start" || state == "OFF")
    {
      Serial.write("O");
      //    Bt.println("ONE");
      state = "ON";
    }

    if (Serial.available())
    {
      x = Serial.read();  //receivng password from the GUI
      //DATA EXTRACTION
      if (x == ';')
      {
        connection = false ;
      }
      if (connection)
      {
        data += x ;
      }
      if (x == '@')
      {
        connection = true ;
      }
    }
    if (data.length() == 4) {
      if (data.equals(password)) { // checking password is right or not
              Serial.write("R");
              data = "";
              digitalWrite(Green_Led , HIGH);
              digitalWrite(Red_Led , LOW);
              
              // Openeing the door
              digitalWrite(motor_pin1, HIGH);
              digitalWrite(motor_pin2, LOW) ;
              delay(5000);
             
              // closing the door
              digitalWrite(motor_pin1, LOW);
              digitalWrite(motor_pin2, HIGH) ;
              delay(5000);

      }
      else
      {

        Serial.write("W");
        data = "";
      }
    }
  }

  else
  { // no one in front of the lock
    if (state == "start" || state == "ON")
    {
      Serial.write("F");
      state = "OFF" ;
    }
  }
  digitalWrite(Red_Led , HIGH);
  digitalWrite(Green_Led , LOW);
  digitalWrite(motor_pin1, LOW);
  digitalWrite(motor_pin2, LOW) ;

}
