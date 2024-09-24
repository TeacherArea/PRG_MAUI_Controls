namespace PRG_MAUI_Controls.Models
{
    public class Students
    {
        private static int studentID = 1001;
        private int id;
        private string name;
        private int age;
        private string course;

        public Students()
        {
            Id = studentID++;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Namn kan inte vara tomt.");
                name = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Åldern måste vara större än 0.");
                age = value;
            }
        }

        public string Course
        {
            get { return course; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Kurs kan inte vara tomt.");
                course = value;
            }
        }
    }
}
