using System;

class Program
{
    static void Main()
    {
        bool continueProgram = true;

        while (continueProgram)
        {
            Console.Write("กรุณากรอกครึ่งหนึ่งของสาย DNA: ");
            string dnaHalf = Console.ReadLine();

            if (IsValidSequence(dnaHalf))
            {
                Console.WriteLine("ครึ่งหนึ่งของสาย DNA ปัจจุบัน: " + dnaHalf);

                Console.Write("คุณต้องการทำการสังเคราะห์ DNA หรือไม่ ? (Y/N): ");
                string answer = Console.ReadLine();

                if (answer.ToUpper() == "Y")
                {
                    string replicatedHalf = ReplicateSequence(dnaHalf);
                    Console.WriteLine("ครึ่งหนึ่งของสาย DNA ที่สังเคราะห์: " + replicatedHalf);
                }
                else if (answer.ToUpper() == "N")
                {
                    // ข้ามการดำเนินการสังเคราะห์ DNA
                }
                else
                {
                    Console.WriteLine("โปรดกรอก Y หรือ N เท่านั้น.");
                    continue;
                }
            }
            else
            {
                Console.WriteLine("ครึ่งหนึ่งของสาย DNA ไม่ถูกต้อง.");
            }

            Console.Write("คุณต้องการดำเนินการกับสาย DNA อื่น ๆ หรือไม่ ? (Y/N): ");
            string continueAnswer = Console.ReadLine();

            if (continueAnswer.ToUpper() == "Y")
            {
                continueProgram = true;
            }
            else if (continueAnswer.ToUpper() == "N")
            {
                continueProgram = false;
            }
            else
            {
                Console.WriteLine("โปรดกรอก Y หรือ N เท่านั้น.");
                continue;
            }
        }

        Console.WriteLine("โปรแกรมจบการทำงาน");
    }

    static bool IsValidSequence(string sequence)
    {
        foreach (char baseChar in sequence)
        {
            if (baseChar != 'A' && baseChar != 'T' && baseChar != 'G' && baseChar != 'C')
                return false;
        }
        return true;
    }

    static string ReplicateSequence(string sequence)
    {
        string replicatedSequence = "";

        foreach (char baseChar in sequence)
        {
            if (baseChar == 'A')
                replicatedSequence += 'T';
            else if (baseChar == 'T')
                replicatedSequence += 'A';
            else if (baseChar == 'G')
                replicatedSequence += 'C';
            else if (baseChar == 'C')
                replicatedSequence += 'G';
        }

        return replicatedSequence;
    }
}
