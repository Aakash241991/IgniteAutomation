using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


struct Books
{
    public string title;
    public string author;
    public string subject;
    public int book_id;

};
public class teststructure
{
    public static void main(string[] args)
    {
        Books Book1;
        Books Book2;

        Book1.title = "C Programming";
        Book1.author = "Aakash Deolekar";
        Book1.subject = "C basics";
        Book1.book_id = 123456;

        Book2.title = "Bikes";
        Book2.author = "Aakash";
        Book2.subject = "Speed thrills";
        Book2.book_id =12345;

        Console.WriteLine("Book1 title : {0}",Book1.title);
        Console.WriteLine("Book1 author :{0}",Book1.author);
        Console.WriteLine("Book1 subject :{0}",Book1.subject);
        Console.WriteLine("Book1 id :{0}",Book1.book_id);

        Console.WriteLine("Book2 title : {0}",Book2.title);
        Console.WriteLine("Book2 author :{0}",Book2.author);
        Console.WriteLine("Book2 subject :{0}",Book2.subject);
        Console.WriteLine("Book2 id :{0}",Book2.book_id);
        Console.ReadKey();

    }
}
