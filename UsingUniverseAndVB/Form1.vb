Imports System.Windows.Forms
Imports U2.Data.Client

Public Class Form1
    Private Sess As UniSession
    Private BOOKTITLES As UniFile
    Private Connected As Boolean = False
    Dim Cmd As UniCommand

    Private Sub Btn_connect_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_connect.Click
        Try
            Sess = UniObjects.OpenSession("localhost", "dev", "ecli123!", "C:\U2\UV\WYCHBOOKS")
        Catch ex As Exception
            MsgBox("Cannot open UniObjects Session Error = " & ex.Message)
            Close()
            Return ' Exit the event handler
        End Try

        Connected = True
        MsgBox("Connection Established")
        Btn_connect.Visible = False

        Try
            BOOKTITLES = Sess.CreateUniFile("BOOK_TITLES")
        Catch ex As Exception
            MsgBox("Cannot create UniFile object")
            Close()
            Return ' Exit the event handler
        End Try

        ' Load data into DataGridView
        If Not GetTitles() Then
            Close()
        End If
    End Sub

    Private Sub fBookTitle_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles MyBase.FormClosed
        If Connected Then
            UniObjects.CloseSession(Sess)
        End If
    End Sub

    Private Sub txtID_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles txtID.LostFocus
        If ReadTitle(txtID.Text) = False Then
            txtID.Text = ""
            txtID.Focus()
        End If
    End Sub

    Public Function ReadTitle(ByVal TitleId As String) As Boolean
        Try
            BOOKTITLES.Read(TitleId)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        txtTitle.Text = BOOKTITLES.Record.Extract(1).ToString
        txtAuthorID.Text = BOOKTITLES.Record.Extract(2).ToString
        cboType.Text = BOOKTITLES.Record.Extract(6).ToString
        txtISBN.Text = BOOKTITLES.Record.Extract(8).ToString
        txtStock.Text = BOOKTITLES.Record.Extract(5).ToString
        txtPrice.Text = Sess.Oconv(BOOKTITLES.Record.Extract(9).ToString, "MD2")
        cboDept.Text = BOOKTITLES.Record.Extract(11).ToString
        cboGenre.Text = BOOKTITLES.Record.Extract(12).ToString

        Return True
    End Function

    Private Sub ClearFields()
        txtTitle.Text = ""
        txtAuthorID.Text = ""
        cboType.Text = ""
        txtISBN.Text = ""
        txtStock.Text = ""
        txtPrice.Text = ""
        cboDept.Text = ""
        cboGenre.Text = ""
    End Sub

    Private Sub btn_update_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_update.Click
        BOOKTITLES.Record.Replace(1, txtTitle.Text)
        BOOKTITLES.Record.Replace(2, txtAuthorID.Text)
        BOOKTITLES.Record.Replace(6, cboType.Text)
        BOOKTITLES.Record.Replace(8, txtISBN.Text)
        BOOKTITLES.Record.Replace(9, Sess.Iconv(txtPrice.Text, "MD2"))
        BOOKTITLES.Record.Replace(11, cboDept.Text)
        BOOKTITLES.Record.Replace(12, cboGenre.Text)

        Try
            BOOKTITLES.Write()
        Catch ex As Exception
            MsgBox("Cannot write data")
            Exit Sub
        End Try
        MsgBox("Record updated")
        ClearFields()
        txtID.Focus()
    End Sub

    Public Function GetTitles() As Boolean
        Dim Cmd As UniXML
        Dim DS As New DataSet
        Try
            Cmd = Sess.CreateUniXML
            Cmd.GenerateXML("SORT BOOK_TITLES SHORT_TITLE AUTHOR_NAME")
            DS = Cmd.GetDataSet

            'Set up DataGridView data source
            DataGridView1.DataSource = DS
            DataGridView1.DataMember = "BOOK_TITLES"
            DataGridView1.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        Return True
    End Function

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim TitleId As String
        TitleId = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
        txtID.Text = TitleId
        ReadTitle(TitleId)
    End Sub

    Private Sub title_id_label_Click(sender As Object, e As EventArgs) Handles title_id_label.Click

    End Sub
End Class
