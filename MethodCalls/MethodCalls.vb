'Jason Permann
'Spring 2025
'RCET2265
'Method Calls
'https://github.com/JaceFoxman/MethodCalls.git

Option Explicit On
Option Strict On
Module MethodCalls

    Sub Main()
        Dim myLuckyNumber As Integer = 7

        Console.WriteLine("Hello from Sub Main!!")
        Console.WriteLine($"My lucky number is {myLuckyNumber}")
        'just writing the name of the other sub will call it
        MyOtherSub()

    End Sub


    'must have a name before clicking enter to get end sub to appear
    Sub MyOtherSub()
        Dim myLuckyNumber As Integer = 5
        Console.WriteLine("Hello from my OtherSubMain!!")
        Console.WriteLine($"My lucky number is {myLuckyNumber}")
    End Sub



End Module
