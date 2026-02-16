namespace stromforbruget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strømforbrug og omkostninger over en 24-timers periode for et familiehus: ");
            //Eksempel på udskrift i konsol: Time 0: 1.25kWh Pris: 3.41dkk, total pris pr. time: kWh * Pris = 4.2625
            /* Kombiner disse data og beregn samlede omkostninger  for strømforbruget i løbet af et døgn
             * Udskriv til konsolvindue hvor meget strøm der er brugt på den pågældende time, samt prisen og den totalt pris pr. time
             * Sidst, udskriv totalpris for hele døgnet
             */ 

            //Array til strømforløb
            double[] kWh = { 1.25, 2.4, 1.96, 1.7, 0.81, 0.81, 0.62, 2.23, 1.7, 1.92, 0.54, 2.44, 2.16, 0.92, 0.86, 0.87, 1.11, 1.55, 1.36, 1.08, 1.72, 0.78, 1.08, 1.23 };

            //Array til pris
            double[] price = { 3.41, 4.07, 2.9, 3.52, 3.68, 2.59, 3.72, 2.84, 2.63, 4.4, 4.43, 4.12, 3.11, 2.7, 3.87, 3.38, 2.74, 3.49, 2.57, 4.32, 3.02, 3.83, 3.12, 3.54 };

            //Variabel til at smide totalpris pr. time
            double timePris = 0;
         
            //Udskriv hvor meget strøm der er brugt på den pågældende time samt prisen:
            for (int i = 0; i < kWh.Length; i++)
            {
                Console.WriteLine($"Dit forbrug er på time: {i}. Du har brugt: {kWh[i]} kWh og timeprisen er: {price[i]} DKK ");

                //Udskriver den totale pris pr. time
                timePris = kWh[i] * price[i];
                Console.WriteLine($"Den totale pris pr. time er: {timePris} DKK");

            }

        }
    }
}
