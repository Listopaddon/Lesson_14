namespace Lesson_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SquadProvide squadProvide = new SquadProvide();
            Squad squad = squadProvide.Desirialize( " ");

            //Squad squad1 = squad;

            //squadProvide.SerializeInXML("D:\\Lesson_14\\Super hero squad2.xml", squad1);
        }
    }
}