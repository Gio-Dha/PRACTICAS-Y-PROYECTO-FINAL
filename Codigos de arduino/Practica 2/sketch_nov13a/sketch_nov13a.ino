#include "DHT.h"

#define DHTPIN 8
#define DHTTYPE DHT11

DHT dht(DHTPIN, DHTTYPE);

void setup() {
  Serial.begin(9600);
  dht.begin();
}

void loop() {
  float h = dht.readHumidity();
  float t = dht.readTemperature();
  
  if (isnan(h) || isnan(t)) {
    Serial.println("Error");
    return;
  }

  // 🔥 ENVÍO CORRECTO PARA C#
  Serial.print(h);
  Serial.print(",");
  Serial.println(t);

  delay(1000);
}

