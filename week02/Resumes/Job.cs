    public class Resume
    {
        public string _name = "";
        public string _jobs = "List<Job>";
        public Resume()
        {
        }
        public void Display()
        {
            
        }
    }
    public class Job
    {
        public string _company = "";
        public string _jobTitle = "";
        public string _startYear = "";
        public string _endYear = "";
    
        public Job()
        {
        }
        public void Display()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }
    
    }