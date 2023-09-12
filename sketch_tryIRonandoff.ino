const int sampleWindow = 50;                              // Sample window width in mS (50 mS = 20Hz)
unsigned int sample;
 
#define SENSOR_PIN A0

int ledPin = 13;
int irPin = 3;
int dTime = 100;
int totalDistance;


void setup() {
  // put your setup code here, to run once:
  pinMode(ledPin,OUTPUT);
  pinMode(irPin,INPUT);
  pinMode (SENSOR_PIN, INPUT); // Set the signal pin as input  


  
  Serial.begin(9600);


}
















void loop() {

      unsigned long startMillis= millis();                   // Start of sample window
      float peakToPeak = 0;                                  // peak-to-peak level
    
      unsigned int signalMax = 0;                            //minimum value
      unsigned int signalMin = 1024;                         //maximum value
    
                                                              // collect data for 50 mS
      while (millis() - startMillis < sampleWindow)
      {
          sample = analogRead(SENSOR_PIN);                    //get reading from microphone
          if (sample < 1024)                                  // toss out spurious readings
          {
            if (sample > signalMax)
            {
                signalMax = sample;                           // save just the max levels
            }
            else if (sample < signalMin)
            {
                signalMin = sample;                           // save just the min levels
            }
          }
      }


              //Serial.print("Loudness: ");
          // Serial.print(db);
            //Serial.println("dB");
            
            //delay(200); 
          
            peakToPeak = signalMax - signalMin;                    // max - min = peak-peak amplitude
            int db = map(peakToPeak,20,900,49.5,90);             //calibrate for deciBels



          // int irValue = digitalRead(irPin);

          // //Serial.println(irValue);

          // if(irValue == LOW){
          //   digitalWrite(ledPin,HIGH);

          //   totalDistance += 3;

          // Serial.print(totalDistance);


          // delay(dTime);
          // } else{
          //   digitalWrite(ledPin,LOW);
          //   delay(dTime);

          // }


          // Serial.print(",");



          Serial.println((String)db+"A");



          //always check the pin cables


}













