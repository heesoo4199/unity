#include <Wire.h>

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  Wire.begin();
  Wire.beginTransmission(0b1101000);
}

void loop() {
  // put your main code here, to run repeatedly:

}