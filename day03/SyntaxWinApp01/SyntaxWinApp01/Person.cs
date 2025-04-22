namespace SyntaxWinApp01
{
    /// <summary>
    /// ㅋㅋ
    /// </summary>
    internal class Person
    {
        public Person() { }
        public Person(string name, int age, char gender,  string phone)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Phone = phone;
        }

        public string Name { get; set; }
        public int Age {
            get { return Age; } 
            set
            {
                if (value < 0 || value > 200)
                {
                    Age = 20;
                }
                else
                {
                    Age = value;
                }
            } 
        }
        public char Gender { get; set; }
        public string Phone { get; set; }

        public override string ToString()
        {
            return $" 이름, {Name}\r\n 나이, {Age}세 \r\n 성별, {Gender}\r\n 핸드폰, {Phone}";
        }

        public void GetUp()
        {
            MessageBox.Show($"{Name}아 학교가야지~ 일어나!");
        }

        public void GoToSchool()
        {
            MessageBox.Show($"{Name}이가 학교로 뛰어갑니다.");
        }
    }
    
}
