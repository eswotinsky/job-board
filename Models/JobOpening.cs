using System;
using System.Collections.Generic;

namespace JobBoard.Models
{
    public class JobOpening
    {
        private string _title;
        private string _description;
        private string _contactInfo;

        private static List<JobOpening> _instances = new List<JobOpening> {};

        public JobOpening(string title, string description, string contactInfo)
        {
            _title = title;
            _description = description;
            _contactInfo = contactInfo;

        }

        public string GetTitle()
        {
            return _title;
        }

        public string GetDescription()
        {
            return _description;
        }

        public string GetContactInfo()
        {
            return _contactInfo;
        }

        public void Save()
        {
            _instances.Add(this);
        }

        public static List<JobOpening> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }
    }
}
