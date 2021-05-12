using System;
// Cole Dickson
// IT112
// NOTES: notes the instructor should read
// BEHAVIORS NOT IMPLIMENTED AND WHY: 
namespace Dickson_Dialer
{
    class Program
    {
        
        public Phone[] info(string[] info, Phone[] supervisor)
        {

            for (int i = 0; i < info.Length; i++)
            {
                if (info[i][info[i].Length - 1] == '1')
                {
                    int checker = info[i].IndexOf("(");
                    string pNumber = info[i].Substring(checker, 14);
                    string pName = info[i].Substring(0, checker - 1);
                    HomePhone temp = new HomePhone(info[i], pNumber, pName);
                    supervisor[i] = temp;
                }
                else if (info[i][info[i].Length - 1] == '2')
                {
                    int checker = info[i].IndexOf("(");
                    string pNumber = info[i].Substring(checker, 14);
                    string pName = info[i].Substring(0, checker - 1);
                    CellPhone temp = new CellPhone(info[i], pNumber, pName);
                    supervisor[i] = temp;
                }
            }
            return supervisor;
        }
        static void Main(string[] args)
        {
            Phone[] dialList = new Phone[10];
            Program thing = new Program();
            string[] infoList = { "CompuTest,(303) 985-5060,1", "Curtis Manufacturing,(603) 532-4123,2" , "Data Functions,(800) 876-2524,1",
            "Donnay Repair,(708) 397-3330,1", "ErgoNomic Inc,(360) 434-3894,1", "ErgoSource,(800) 969-4374,1", "Fox Bay Industries,(800) 874-8527,2",
            "Glare-Guard,(800) 545-6254,2", "Hazard Comm Specialists,(407) 783-6641,2", "Komfort Support,(714) 472-4409,2"};
            dialList = thing.info(infoList, dialList);
            for(int i = 0; i<dialList.Length; i++)
            {
                Console.WriteLine(dialList[i].Dial());
            }

            /*dialList[0] = new Phone("CompuTest,(303) 985-5060,1");
            dialList[1] = new Phone("Curtis Manufacturing,(603) 532-4123,2");
            dialList[2] = new Phone("Data Functions,(800) 876-2524,1");
            dialList[3] = new Phone("Donnay Repair,(708) 397-3330,1");
            dialList[4] = new Phone("ErgoNomic Inc,(360) 434-3894,1");
            dialList[5] = new Phone("ErgoSource,(800) 969-4374,1");
            dialList[6] = new Phone("Fox Bay Industries,(800) 874-8527,2");
            dialList[7] = new Phone("Glare-Guard,(800) 545-6254,2");
            dialList[8] = new Phone("Hazard Comm Specialists,(407) 783-6641,2");
            dialList[9] = new Phone("Komfort Support,(714) 472-4409,2");
            Console.WriteLine(dialList[0].Dial());*/



            /*string boi = "CompuTest,(303) 985-5060,1";
            CellPhone thing = new CellPhone(boi);
            Console.WriteLine(thing.Dial());*/
        }
    }
}
