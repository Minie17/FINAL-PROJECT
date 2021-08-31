using System;

namespace day5_task_3
{
    class Program
    {
        enum MeetingImportance
        {
            Trivial,
            Regular,
            Critical,
        }
        public static void Main()
        {
            MeetingImportance meet = MeetingImportance.Critical;
            int value = (int)MeetingImportance.Critical;

            if (meet == MeetingImportance.Critical)
            {
                Console.WriteLine("Critical" + value);
            }
            else if (meet == MeetingImportance.Trivial)
            {
                Console.WriteLine("Trivial" + value);
            }

            else if (meet == MeetingImportance.Regular)
            {
                Console.WriteLine("Regular" + value);
            }
        }
    }
}

        
