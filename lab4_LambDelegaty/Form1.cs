using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4_LambDelegaty
{
    public partial class Form1 : Form
    {

        List<Student> students = new List<Student>
            {
                new Student(1),
                new Student(4),
                new Student(8),
                new Student(9),
                new Student(67),
                new Student(43),
                new Student(32),
                new Student(39),
                new Student(82),
                new Student(30),
                new Student(32),
                new Student(36)
            };

        public Form1()
        {
            InitializeComponent();
        }

         public static Random random = new Random();

        private void but_Pow_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out int x);
            int.TryParse(textBox2.Text, out int y);
            Func<double> result = () => Math.Pow(x, y);
            textBox3.Text = result().ToString();
        }

        private void but_Con_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text.ToString();
            string y = textBox2.Text.ToString();
            Func<string> cocncat = () => x + ' ' + y;
            textBox3.Text = cocncat().ToString();
        }

        private void but_Rand_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out int x);
            string chars = "abcdefghijklmnopqrstuwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*-_+/~`";
            string result = new string(
                Enumerable.Repeat(chars, x)
                      .Select(s => s[random.Next(s.Length)])
                      .ToArray());
            textBox3.Text = result;
        }

        private void but_Tab_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out int x);
            int.TryParse(textBox2.Text, out int y);
            int[] Arr = new int[] {2, 4, 8, 10, 3, 5, 7, 0, 1, 100};
            y = Arr[y];
            Func<double> result = () => Math.Pow(x, y);
            textBox3.Text = result().ToString();
        }

        public delegate int myDelegate<T>(T first, T second);
        //public static int mySortingMethod<T>(T firstDigit, T secondDigit) where T : IComparable<T>
        public static int mySortingMethod_1(int firstDigit, int secondDigit)
        {
            return firstDigit.CompareTo(secondDigit);
        }

        private void but_SortMethod_Click(object sender, EventArgs e)
        {
            List<int> _l = new List<int>
            {
                10, 9, 1231, 1327, 6, 123
            };

            myDelegate<int> handler = mySortingMethod_1;
            _l.Sort((x, y) => handler(x, y));
            string str = "";
            foreach (int i in _l)
            {
                str += i + " ";
            }

            textBox3.Text = str;
        }

        private void but_Sort_Asc_Desc_Click(object sender, EventArgs e)
        {

            List<Student> students = this.students;

            students = students.OrderBy(student => student.studentId).ToList();

            string studentsOrderedBy = "";
            foreach (Student student in students)
            {
                studentsOrderedBy += student.studentId + " ";
            }
            studentsOrderedBy += "\n";
            students = students.OrderByDescending(student => student.studentId).ToList();
            foreach (Student student in students)
            {
                studentsOrderedBy += student.studentId + " ";
            }

            textBox3.Text = studentsOrderedBy;
        }

        private void but_Sort_Even_Odd_Click(object sender, EventArgs e)
        {
            List<Student> students = this.students;

            Func<List<Student>, List<Student>> EvenOddLambda = (studentList) =>
            {
                List<Student> studentsEven = new List<Student>();
                List<Student> studentsOdd = new List<Student>();
                foreach (Student student in studentList)
                {
                    if (student.studentId % 2 == 0)
                    {
                        studentsEven.Add(student);
                    }
                    else
                    {
                        studentsOdd.Add(student);
                    }
                }

                studentsEven = studentsEven.OrderBy(item => item.studentId).ToList();
                //studentsOdd = studentsOdd.OrderBy(item => item.studentId).ToList();

                studentsEven.AddRange(studentsOdd.OrderBy(item => item.studentId).ToList());

                return studentsEven;
            };

            string sortedStudents = "";
            foreach (Student student in EvenOddLambda(students))
            {
                sortedStudents += student.studentId + " ";
            }

            textBox3.Text = sortedStudents;
        }

        private void but_9_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out int x);
            int.TryParse(textBox2.Text, out int y);

            textBox3.Text = nehochu(x).Invoke(y).ToString(); 
        }
        
        private Func<int, double> nehochu (int x)
        {
            Func<int, double> PowLambda = (digit) =>
            {
                return Math.Pow(digit, x);
            };

            return PowLambda;
        }

        private void but_Sort_Alfabet_Click(object sender, EventArgs e)
        {
            Func<string, List<string>> parseStringDigitsToInt = (inputNumbers) =>
             {
                 //List<int> result = new List<int>();
                 List<string> intsAsString = inputNumbers.Split(',').ToList();
                 //foreach (string inp in intsAsString)
                 //{
                 //    int.TryParse(inp, out int buf);
                 //    result.Add(buf);
                 //}
                 //return result;
                 return intsAsString;
             };
            
            //Func<int, int> splittingBy = (number) =>
            //{
            //    int restNum = number;
            //    List<int> result = new List<int>();
            //    do
            //    {
            //        result.Add(restNum % 10);
            //        restNum /= 10;
            //    } while (restNum >= 1);
            //    result.Reverse();

            //    return result[0];
            //};
            //Func<int, int> getCount = (number) =>
            //{
            //    int restNum = number;
            //    int i = 0;
            //    do
            //    {
            //        restNum /= 10;
            //        i++;
            //    } while (restNum >= 1);

            //    return i;
            //};
            //List<int> inputDigits = parseStringDigitsToInt.Invoke(textBox1.Text);
            List<string> inputDigits = parseStringDigitsToInt.Invoke(textBox1.Text);
            //inputDigits = inputDigits.OrderBy(value => splittingBy(value)).ToList();
            inputDigits.Sort();
            string resultStr = "";
            //foreach (int str in parseStringDigitsToInt.Invoke(textBox1.Text))
            foreach (string str in inputDigits)
            {
                resultStr += str + " ";
            }
            textBox3.Text = resultStr;
        }
    }
}
