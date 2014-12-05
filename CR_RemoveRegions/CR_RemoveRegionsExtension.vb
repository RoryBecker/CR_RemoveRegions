Imports System.ComponentModel.Composition
Imports DevExpress.CodeRush.Common

Namespace CR_RemoveRegions
  <Export(GetType(IVsixPluginExtension))> _
  Public Class CR_RemoveRegionsExtension
	  Implements IVsixPluginExtension
  End Class
End Namespace