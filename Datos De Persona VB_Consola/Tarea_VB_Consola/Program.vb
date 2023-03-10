Imports System

Module Program
    Sub Main(args As String())
        Dim index As Integer = 0
        Dim lengtch As Integer = 0
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("[°]--------------------------[°]")
        Console.WriteLine(" | ¡CUANTOS CONTACTOS QUIERE¡ |")
        Console.WriteLine("[°]--------------------------[°]")
        Console.ForegroundColor = ConsoleColor.DarkYellow
        lengtch = Integer.Parse(Console.ReadLine())
        Console.Clear()
        Dim c As Contacto()
        While index < lengtch
            c = New Contacto(lengtch - 1) {}
            c(index) = New Contacto()
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.WriteLine("[°]---------------------------------[°]")
            Console.WriteLine(" | =INGRESE EL NOMBRE DE LA PERSONA= |")
            Console.WriteLine("[°]---------------------------------[°]")
            Console.ForegroundColor = ConsoleColor.DarkYellow
            c(index).NombreProp = Console.ReadLine()
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.WriteLine("[°]-------------------------------[°]")
            Console.WriteLine(" | =INGRESE EL NUMERO DE TELEFONO= |")
            Console.WriteLine("[°]-------------------------------[°]")
            Console.ForegroundColor = ConsoleColor.DarkYellow
            c(index).telefono = Console.ReadLine()
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.WriteLine("[°]-------------------------------[°]")
            Console.WriteLine(" | =INGRESE EL CORREO ELECTRONICO= |")
            Console.WriteLine("[°]-------------------------------[°]")
            Console.ForegroundColor = ConsoleColor.DarkYellow
            c(index)._correo = Console.ReadLine()
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.WriteLine("[°]--------------------------------[°]")
            Console.WriteLine(" | =INGRESE LA FECHA DE NACIMIENTO= |")
            Console.WriteLine("[°]--------------------------------[°]")
            Console.ForegroundColor = ConsoleColor.DarkYellow
            c(index).FechaNacimiento = Date.Parse(Console.ReadLine())
            Console.WriteLine(c(index).ToString())
            index += 1
        End While
        Console.ReadKey()
    End Sub
End Module
