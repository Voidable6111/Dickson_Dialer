using System;
// Cole Dickson
// IT112
// NOTES: I'm not entirely sure if I handled the 3 args in Phone's constructor or it's subclasses' constructors correctly, but everything works.
// BEHAVIORS NOT IMPLIMENTED AND WHY: I don't believe I'm missing anything.
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
        }
    }
}
