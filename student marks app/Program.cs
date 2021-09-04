using System;
using System.IO;

namespace student_marks_app
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs;
            string studentname;
            int[] studentmarks = new int[3];
            int avgmarks;
        public static int numOfStudents = 0;
        public BinaryTesting(string studentname, int[] studentmarks, int avgmarks)
        {
            this.studentname = studentname;
            this.studentmarks = studentmarks;
            this.avgmarks = avgmarks;
        }
        public void WriteData()
        {
            FileStream fs = new FileStream(@"E:/student.txt", FileMode.Open, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(Studentname);
            for (int i = 0; i < 3; i++)
            {
                bw.Write(studentmarks[i]);
            }
            bw.Write(avgmarks);
            bw.Flush();
            bw.Close();
            fs.Close();
            numOfStudents++;
        }
        public void ReadData()
        {
            fs = new FileStream(@"E:/stuedent.txt", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            for (int j = 0; j < numOfStudents; j++)
            {
                studentname = br.ReadString();
                if (studentname == null)
                    break;
                Console.Write(studentname + "\t");
                for (int i = 0; i < 3; i++)
                {
                    studentmarks[i] = br.ReadInt32();
                    Console.Write(studentmarks[i] + "\t");
                }
                avgmarks = br.ReadInt32();
                Console.WriteLine(avgmarks);
            }
            br.Close();
            fs.Close();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string studentName;
            int[] studentMarks = new int[3];
            int i = 0, totMarks = 0, avgMarks;
            string resp;
            BinaryTesting bt;
            do
            {
                i++;
                Console.Write("Enter Student {0} Name: ", i);
                studentName = Console.ReadLine();

                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Enter Student {0} Subject {1} Marks: ", i, (j + 1));
                    studentMarks[j] = Convert.ToInt32(Console.ReadLine());
                    totMarks += studentMarks[j];
                }
                avgMarks = totMarks / 3;
                bt = new BinaryTesting(studentName, studentMarks, avgMarks);
                bt.WriteData();
                Console.WriteLine("Press Y to continue");
                resp = Console.ReadLine();
            } while (resp == "Y" || resp == "y");
            bt.ReadData();
        }
    }
}


        }
    }
}
