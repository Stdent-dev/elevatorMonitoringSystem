const int sampleWindow = 50;                              // Sample window width in mS (50 mS = 20Hz)
unsigned int sample;
 
#define SENSOR_PIN A1
 
//IR
int irPin = 3;
int dTime = 100;
int totalDistance;



void setup ()  
{   
  pinMode (SENSOR_PIN, INPUT); // Set the signal pin as input  

  //IR
    pinMode(irPin,INPUT);
  Serial.begin(9600);
}  
 
   
void loop ()  
{ 
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
 
   peakToPeak = signalMax - signalMin;                    // max - min = peak-peak amplitude
   int db = map(peakToPeak,20,900,49.5,90);             //calibrate for deciBels
 
  int db2 = db;


//IR

int irValue = digitalRead(irPin);

          //Serial.println(irValue);

          





  //Serial.print("Loudness: ");
  Serial.print(db);
  Serial.print(",");

  if(irValue == LOW){
            //digitalWrite(ledPin,HIGH);

            totalDistance += 3;

        //Serial.println("A");
       Serial.println(totalDistance);


          
          } 
          
          else{

 Serial.println("B");
  //Serial.println();
          }

 //Serial.println(irValue);
  
 
  delay(500); 





}
