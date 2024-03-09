Public Class Form1

    Public Structure SDateInterval
        Dim StartDate As Date    ' تاريخ بداية الفترة
        Dim EndDate As Date     ' تاريخ نهاية الفترة
    End Structure

    ' دالة الاختبار
    Public Function IntervalConflict(ByVal Period1 As SDateInterval, ByVal Period2 As SDateInterval) As Boolean
        If ((Period1.StartDate >= Period2.StartDate) And (Period1.StartDate <= Period2.EndDate)) Or _
                ((Period1.EndDate >= Period2.StartDate) And (Period1.EndDate <= Period2.EndDate)) Then
            Return True    ' تعارض
        Else
            Return False    ' لا يوجد تعارض
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Period1 As SDateInterval
        Dim Period2 As SDateInterval

        ' القيم التالية للتجربة - يمكن قراءتها من مربعات نص أو غيرها
        Period1.StartDate = dtFrom.Value.ToShortDateString
        Period1.EndDate = dtTo.Value.ToShortDateString

        Period2.StartDate = dt1.Value.ToShortDateString
        Period2.EndDate = dt2.Value.ToShortDateString

        If IntervalConflict(Period2, Period1) Then
            MsgBox("Conflicts")
        Else
            MsgBox("No conflict")
        End If
    End Sub
End Class
