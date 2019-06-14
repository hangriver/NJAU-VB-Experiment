Class MainWindow
    Sub Form_Paint() Handles ListBox.Loaded
        Dim a As Integer
        Console.WriteLine("ran")
        ListBox.Items.Add("中国")
        ListBox.Items.Add("美国")
        ListBox.Items.Add("英国")
        ListBox.Items.Add("法国")
        ListBox.Items.Add("俄国")
    End Sub
    Private Sub ListBox_SelectionChanged(sender As Object, e As SelectionChangedEventArgs)
        TextBox.Text = ListBox.SelectedItem
    End Sub

    Private Sub AddItem_Click(sender As Object, e As RoutedEventArgs) Handles AddItem.Click
        ListBox.Items.Add(TextBox.Text)
    End Sub

    Private Sub RemoveItem_Click(sender As Object, e As RoutedEventArgs) Handles RemoveItem.Click
        ListBox.Items.Remove(TextBox.Text)
    End Sub

    Private Sub Quit_Click(sender As Object, e As RoutedEventArgs) Handles Quit.Click
        End
    End Sub
End Class
