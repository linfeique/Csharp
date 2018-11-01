using System;
using Spire.Doc;
using System.Drawing;
using Spire.Doc.Documents;

namespace Senai.Word
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, cpf;
            
            //Recebendo nome para o certificado.
            Console.WriteLine("Informe seu nome completo: ");
            nome = Console.ReadLine();

            //Recebendo CPF do usuário.
            System.Console.WriteLine("Digite o CPF: ");
            cpf = Console.ReadLine();

            //limpando a tela
            Console.Clear();

            Document doc = new Document();

            Section section = doc.AddSection();

            Paragraph titulo = section.AddParagraph();

            titulo.AppendText("CERTIFICADO");

            ParagraphStyle s1 = new ParagraphStyle(doc);

            s1.Name = "TitleTextColor";

            s1.CharacterFormat.TextColor = Color.Green;

            s1.CharacterFormat.FontName = "Algerian";

            s1.CharacterFormat.FontSize = 30;

            titulo.Format.HorizontalAlignment = HorizontalAlignment.Center;

            doc.Styles.Add(s1);
            titulo.ApplyStyle (s1.Name);

            Paragraph texto = section.AddParagraph();

            texto.AppendText($"Ceritificado que {nome}, portador(a) do CPF {cpf}, está apto a utilizar a Spire.doc para a manipulação de arquivos do Word por meio do C#");

             ParagraphStyle s2 = new ParagraphStyle(doc);

            s2.Name = "TitleTextColor";

            s1.CharacterFormat.TextColor = Color.Red;

            s1.CharacterFormat.FontName = "Arial";

            s1.CharacterFormat.FontSize = 25;

            titulo.Format.HorizontalAlignment = HorizontalAlignment.Justify;

            doc.Styles.Add(s2);

            texto.ApplyStyle(s2.Name);

            System.Console.WriteLine("Certificado obtido com sucesso");

            doc.SaveToFile(@"C:\Users\44846245837\Desktop\Certificado.docx");
        }
    }
}
