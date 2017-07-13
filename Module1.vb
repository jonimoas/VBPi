Module Module1

    Sub Main()
        Dim x, y, total, z, out, ins, o, d, pi As Double
        z = Console.ReadLine
        x = -1
        y = -1
        total = 0
        o = (1 / z)
        Do While x <= 1
            Do While y <= 1
                d = System.Math.Sqrt(x ^ 2 + y ^ 2)
                If d >= 1 Then
                    out = out + 1
                Else
                    ins = ins + 1
                End If
                total = total + 1
                y = y + o
                Console.Title = "(" & x & " , " & y & ")"
            Loop
            x = x + o
            y = -1
            Console.Title = "(" & x & " , " & y & ")"
        Loop
        pi = (ins / (ins + out)) * 4
        Console.Out.WriteLine(pi)
        Console.Out.WriteLine(total)
        Stop
    End Sub

End Module
