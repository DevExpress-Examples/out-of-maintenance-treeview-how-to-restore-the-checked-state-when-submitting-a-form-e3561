Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc

Namespace MvcApp_TreeView.Controllers
	Public Class HomeController
		Inherits Controller
		Private privateCheckedValues As Object
		Public Property CheckedValues() As Object
			Get
				Return privateCheckedValues
			End Get
			Set(ByVal value As Object)
				privateCheckedValues = value
			End Set
		End Property

		Public Function Index() As ActionResult
			ViewBag.Message = "Welcome to DevExpress Extensions for ASP.NET MVC!"
			Return View(CheckedValues)
		End Function

		<HttpPost> _
		Public Function PostTreeViewValues() As ActionResult
			CheckedValues = Request.Params("hf")

			ViewBag.Message = "The TreeView state has been restored successfully"
			Return View("Index", CheckedValues)
		End Function
	End Class
End Namespace
