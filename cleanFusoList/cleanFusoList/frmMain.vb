Public Class frmMain

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Dispose()
    End Sub

    'open the file for processing
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\"
        fd.Filter = "All files (*.*)|*.*|CSV Files (*.csv)|*.csv"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        'populate data fields
        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            tbPath.Text = (strFileName)
            rbCanada.Enabled = True
            rbCanada.Checked = True
            rbUS.Enabled = True
            btnRun.Enabled = True
        End If
    End Sub

    'converts non quoted csv strings to quoted csv strings
    Private Sub runMyStuff()
        Dim path As String = tbPath.Text()
        Dim isCanada As Boolean = False
        Dim header As String
        If rbCanada.Checked Then
            isCanada = True
            'header for canada
            header = Chr(34) + "MDDLR" + Chr(34) + "," + Chr(34) + "DLR_NAME" + Chr(34) + "," + Chr(34) + "AOR_CITY" + Chr(34) + "," + Chr(34) + "AOR_STATE" + Chr(34) + "," + Chr(34) + "AOR_ZIP" + Chr(34) + "," + Chr(34) + "MDPOLKZIP" + Chr(34) + "," + Chr(34) + "RUNDATE" + Chr(34)
        Else
            'header for US
            header = Chr(34) + "MDDLR" + Chr(34) + "," + Chr(34) + "DLR_NAME" + Chr(34) + "," + Chr(34) + "AOR_CITY" + Chr(34) + "," + Chr(34) + "AOR_COUNTY" + Chr(34) + "," + Chr(34) + "AOR_STATE" + Chr(34) + "," + Chr(34) + "MDPOLKZIP" + Chr(34) + "," + Chr(34) + "MDCNRY" + Chr(34) + "," + Chr(34) + "MDCURN" + Chr(34) + "," + Chr(34) + "MDREGN" + Chr(34) + "," + Chr(34) + "MDDIST" + Chr(34) + "," + Chr(34) + "RUNDATE" + Chr(34)
        End If
        Dim myReader = New Microsoft.VisualBasic.FileIO.TextFieldParser(path)
        myReader.SetDelimiters(",")
        Dim currentRow As String()
        Dim fileList As ArrayList = New ArrayList
        fileList.Add(header)
        Dim count = 0
        'read the file
        While Not myReader.EndOfData
            Dim myStr As String = ""
            Try
                currentRow = myReader.ReadFields()
                'only add non header info
                If count > 0 Then
                    Dim count2 = 0
                    For Each field In currentRow
                        If isCanada Then
                            If count2 < 6 Then
                                If field = "UNASS" Then
                                    field = "OPEN"
                                End If
                                myStr += "" + Chr(34) + field + Chr(34) + ","
                            End If
                            If count2 = 5 Then

                                Dim todaysdate As String = String.Format("{0:MM/dd/yyyy}", DateTime.Now)
                                myStr += Chr(34) + todaysdate + Chr(34)
                            End If
                        Else
                            myStr += "" + Chr(34) + field + Chr(34)
                            If count2 < 10 Then
                                myStr += ","
                            End If
                        End If
                        count2 += 1

                    Next
                    fileList.Add(myStr)
                End If
            Catch ex As Microsoft.VisualBasic.
                                FileIO.MalformedLineException
                MsgBox("Line " & ex.Message &
                        "is not valid and will be skipped.")
            Finally
                count += 1
            End Try
        End While
        Dim worked = False
       
        buildCleanCSV(fileList)
    End Sub

    Private Sub buildCleanCSV(ByRef vals As ArrayList)

        Dim pat = ""
        Dim myList As String() = tbPath.Text.Split("\")
        Dim myFileName As String() = myList(myList.Count - 1).Split(".")
        myList(myList.Count - 1) = myFileName(0) & "_clean" & ".csv"
        Dim count = 0
        For Each item In myList
            pat += item.ToString()
            If count < myList.Count - 1 Then
                pat += "\"
            End If
            count += 1
        Next
        MessageBox.Show(pat)
        System.IO.File.Create(pat).Dispose()
        count = 0
        Dim objWriter As New System.IO.StreamWriter(pat, True)
        While count < vals.Count
            objWriter.WriteLine(vals(count))
            count += 1
        End While
        objWriter.Close()
        MessageBox.Show("Finished Processing the CSV file", "Alert")
    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        runMyStuff()
    End Sub
End Class
