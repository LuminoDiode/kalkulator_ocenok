Public Class Form1
    Dim CurrSr As Single = 2     ' Создание переменной текущего среднего балла
    Dim NeedSr As Single = 3.5     ' Создание переменной необходимого среднего балла
    Dim SummaStart As Single = 0  ' Создание переменной для суммы начальных оценок (KolvoOc * CurrSr)
    Dim KolvoOc As SByte = 1     ' Создание перменной кол-ва оценок (SByte от -128 до +127)
    Dim Cicl1 As Byte = 0   ' Переменная кол-ва повторений цикла
    Dim plus As Byte = 0   ' Переменная прибавленных оценок
    Dim KolvoPlus As Byte = 0   ' Переменная кол-ва прибавленных оценок

    Function CurrSrE()     ' Функция ограничения текущего среднего балла от 2 до 5
        If CurrSr >= 5 Then CurrSr = 5
        If CurrSr <= 2 Then CurrSr = 2
        Fix(CurrSr)
        TextBox1.Text = Format(CurrSr, "0.00")   ' И его последующего отображения с 2-мя знаками после запятой.
    End Function

    Function KolvoOcE()     ' Функция ограничения кол-ва оценок от 1 до 100
        If KolvoOc >= 100 Then KolvoOc = 100
        If KolvoOc <= 1 Then KolvoOc = 1
        TextBox2.Text = KolvoOc   ' ' И его последующего отображения
    End Function

    Function NeedSrE()     ' Функция ограничения необходимого среднего балла от 2 до 4.99
        If NeedSr >= 5 Then NeedSr = 4.99
        If NeedSr <= 2 Then NeedSr = 2
        TextBox3.Text = Format(NeedSr, "0.00")   ' И его последующего отображения с 2-мя знаками после запятой.
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LinkLabel1.Hide()
        LinkLabel1.Location = Label5.Location
        TextBox1.ReadOnly = True   ' Запрет на изменение текстбоксов 
        TextBox2.ReadOnly = True
        TextBox3.ReadOnly = True
        TextBox4.ReadOnly = True
        Me.Text = "Оценок для исправления"   ' Свойства окна
        Me.Height = 327
        Me.Width = 764
    End Sub

    ' Задание кнопок для измененя текущего балла

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CurrSr = CurrSr + 1
        Call CurrSrE()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CurrSr = CurrSr + 0.1
        Call CurrSrE()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CurrSr = CurrSr + 0.01
        Call CurrSrE()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CurrSr = CurrSr - 1
        Call CurrSrE()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CurrSr = CurrSr - 0.1
        Call CurrSrE()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        CurrSr = CurrSr - 0.01
        Call CurrSrE()
    End Sub

    ' Задание кнопок для изменения кол-ва оценок

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        KolvoOc = KolvoOc + 10
        Call KolvoOcE()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        KolvoOc = KolvoOc + 1
        Call KolvoOcE()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        KolvoOc = KolvoOc - 10
        Call KolvoOcE()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        KolvoOc = KolvoOc - 1
        Call KolvoOcE()
    End Sub

    ' Задание кнопок для изменения необходимого среднего балла

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        NeedSr = NeedSr + 1
        Call NeedSrE()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        NeedSr = NeedSr + 0.1
        Call NeedSrE()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        NeedSr = NeedSr + 0.01
        Call NeedSrE()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        NeedSr = NeedSr - 1
        Call NeedSrE()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        NeedSr = NeedSr - 0.1
        Call NeedSrE()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        NeedSr = NeedSr - 0.01
        Call NeedSrE()
    End Sub

    ' Код кнопки "Рассчитать"

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click

        If CurrSr > NeedSr Then   ' Защита от дурака 1
            MsgBox("Ваш балл уже выше того, который вам нужен!", vbInformation, "Внимание")
        Else
            If RadioButton1.Checked = True Then
                SummaStart = 0   ' Создание переменной изначальной суммы оценок, по кол-ву и среднему баллу от пользователя
                Cicl1 = 0   ' Будет задавать, сколько раз нужно сложить оценки(повторить цикл). С каждым циклом +1, пока не станет равна кол-ву оценок
                plus = 0   ' Прибавленные 5-рки
                KolvoPlus = 0   ' Кол-во прибавленных оценок.
                Do Until Cicl1 = KolvoOc   ' Сложение начальных оценок
                    SummaStart = SummaStart + CurrSr
                    Cicl1 = Cicl1 + 1
                Loop
                Do Until ((SummaStart + plus) / (KolvoOc + KolvoPlus)) >= NeedSr Or KolvoPlus > 50  'Цикл, который будет добовлять 5-ки
                    plus = plus + 5
                    KolvoPlus = KolvoPlus + 1
                Loop
                TextBox4.Text = KolvoPlus   '   Вывод результатов в текстбокс
                Label4.Text = "Необходимо 5:"
            Else
                If RadioButton2.Checked = True Then
                    If NeedSr >= 4 Then   ' Защита от дурака 2
                        MsgBox("Необходимый балл не может быть выше получаемых оценок!", vbInformation, "Внимание")
                    Else                    ' Аналогично для 4
                        SummaStart = 0
                        Cicl1 = 0
                        plus = 0
                        KolvoPlus = 0
                        Do Until Cicl1 = KolvoOc
                            SummaStart = SummaStart + CurrSr
                            Cicl1 = Cicl1 + 1
                        Loop
                        Do Until ((SummaStart + plus) / (KolvoOc + KolvoPlus)) >= NeedSr Or KolvoPlus > 50
                            plus = plus + 4
                            KolvoPlus = KolvoPlus + 1
                        Loop
                        Label4.Text = "Необходимо 4:"
                    End If
                End If
            End If
        End If

        If KolvoPlus > 50 Then   ' Если нужно больше 50 оценок для исправления
            TextBox4.Text = "50+"
        Else
            TextBox4.Text = KolvoPlus
        End If

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click ' Показать ссылку на ВК
        Label5.Hide()
        LinkLabel1.Show()
        LinkLabel1.Enabled = False
        Threading.Thread.Sleep(500)
        LinkLabel1.Enabled = True
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://vk.com/65zio")   ' Страница Автора ВК
    End Sub

End Class