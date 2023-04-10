using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OPD_Section.Forms
{
    public class Data
    {
        public string village_name { get; set; }
        public string house_no { get; set; }
        public string person_id { get; set; }

        public string name { get; set; }
        public string age { get; set; }
        public string gender { get; set; }
        public string contact { get; set; }

        /*public string[] symptom_name = new string[20];
        public string[] symptom_description = new string[20];
        public string[] medicine_name = new string[20];
        public string[] medicine_quantity = new string[20];
        public string[] notes = new string[20];*/

        public List<string> symptom_name = new List<string>();
        public List<string> symptom_description = new List<string>();
        public List<string> medicine_id = new List<string>();
        public List<string> medicine_name = new List<string>();
        public List<string> medicine_quantity = new List<string>();
        public List<string> notes = new List<string>();



        /*        public string[] symptom_name { get; set; }
                public string[] symptom_description { get; set; }


                public string[] medicine_name { get; set; }
                public string[] medicine_quantity { get; set; }

                public string[] notes { get; set; }*/

        public void Destroy()
        {
            
            village_name = null;
            house_no = null;
            person_id = null;
            name = null;
            age = null;
            gender = null;
            contact = null;
            symptom_name = null;
            symptom_description = null;
            medicine_name = null;
            medicine_quantity = null;
        }


    }
}
