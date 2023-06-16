﻿' This file is used by Code Analysis to maintain SuppressMessage
' attributes that are applied to this project.
' Project-level suppressions either have no target or are given
' a specific target and scoped to a namespace, type, member, etc.

Imports System.Diagnostics.CodeAnalysis

<Assembly: SuppressMessage("Major Code Smell", "S3385:""Exit"" statements should not be used", Justification:="Easy Exit of a Try Catch statement", Scope:="member", Target:="~M:ViVeTool_GUI.DatabaseFunctions.LoadCommentsFromDB(System.String)")>
<Assembly: SuppressMessage("Style", "IDE1006:Benennungsstile", Justification:="Naming convention for Debug Subs and Functions", Scope:="member", Target:="~M:ViVeTool_GUI.GUI.__DBG_SetRDDL_Build_Text_Click(System.Object,System.EventArgs)")>
<Assembly: SuppressMessage("Style", "IDE1006:Benennungsstile", Justification:="Naming convention for Debug Subs and Functions", Scope:="member", Target:="~M:ViVeTool_GUI.GUI.__DBG_ChnageLanguage_Click(System.Object,System.EventArgs)")>
<Assembly: SuppressMessage("Style", "IDE1006:Benennungsstile", Justification:="Naming convention for Debug Subs and Functions", Scope:="member", Target:="~M:ViVeTool_GUI.GUI.__DBG_DisableCommentLoadingFromManualFL_Click(System.Object,System.EventArgs)")>
<Assembly: SuppressMessage("Style", "IDE1006:Benennungsstile", Justification:="Naming convention for Debug Subs and Functions", Scope:="member", Target:="~M:ViVeTool_GUI.GUI.__DBG_EnableCommentLoadingFromManualFL_Click(System.Object,System.EventArgs)")>
<Assembly: SuppressMessage("Style", "IDE1006:Benennungsstile", Justification:="Naming convention for Debug Subs and Functions", Scope:="member", Target:="~M:ViVeTool_GUI.GUI.__DBG_GetComments_Click(System.Object,System.EventArgs)")>
<Assembly: SuppressMessage("Style", "IDE1006:Benennungsstile", Justification:="Naming convention for Debug Subs and Functions", Scope:="member", Target:="~M:ViVeTool_GUI.GUI.__DBG_SeeCommentsData_Click(System.Object,System.EventArgs)")>
<Assembly: SuppressMessage("Style", "IDE1006:Benennungsstile", Justification:="Naming convention for Debug Subs and Functions", Scope:="member", Target:="~M:ViVeTool_GUI.GUI.__DBG_SetRDDL_Build_Text_ToNothing_Click(System.Object,System.EventArgs)")>
<Assembly: SuppressMessage("Style", "IDE1006:Benennungsstile", Justification:="Naming convention for Debug Subs and Functions", Scope:="member", Target:="~M:ViVeTool_GUI.SetManual.__DBG_FixLKG_Click(System.Object,System.EventArgs)")>
<Assembly: SuppressMessage("Style", "IDE1006:Benennungsstile", Justification:="Naming convention for Debug Subs and Functions", Scope:="member", Target:="~M:ViVeTool_GUI.SetManual._DBG_FixPriority_Click(System.Object,System.EventArgs)")>
<Assembly: SuppressMessage("Minor Code Smell", "S1075:URIs should not be hardcoded", Justification:="GitHub API URIs don't change much", Scope:="member", Target:="~M:ViVeTool_GUI.GUI.PopulateBuildComboBox")>
<Assembly: SuppressMessage("Minor Code Smell", "S1075:URIs should not be hardcoded", Justification:="The Comments Server URI shouldn't change much", Scope:="member", Target:="~M:ViVeTool_GUI.CommentsClient.SendComment_Thread")>
<Assembly: SuppressMessage("Style", "IDE1006:Benennungsstile", Justification:="Naming convention for Debug Subs and Functions", Scope:="member", Target:="~M:ViVeTool_GUI.GUI.__DBG_SetFeaturePriorityToServiceAsTest_Click(System.Object,System.EventArgs)")>
<Assembly: SuppressMessage("Style", "IDE1006:Benennungsstile", Justification:="Naming convention for Debug Subs and Functions", Scope:="member", Target:="~M:ViVeTool_GUI.GUI.__DBG_QueryEnabledState_401122637_Click(System.Object,System.EventArgs)")>
<Assembly: SuppressMessage("Style", "IDE0044:Modifizierer ""readonly"" hinzufügen", Justification:="<Ausstehend>", Scope:="member", Target:="~F:ViVeTool_GUI.DatabaseFunctions.Build_DT")>
<Assembly: SuppressMessage("Style", "IDE1006:Benennungsstile", Justification:="Naming convention for Debug Subs and Functions", Scope:="member", Target:="~M:ViVeTool_GUI.GUI.__DBG_Load")>
<Assembly: SuppressMessage("Major Code Smell", "S3385:""Exit"" statements should not be used", Justification:="Unsure how to do this better for now", Scope:="member", Target:="~M:ViVeTool_GUI.ViVe_API.Management.FeatureNaming.FindNamesForFeatures(System.Collections.Generic.IEnumerable{System.UInt32})~System.Collections.Generic.Dictionary{System.UInt32,System.String}")>
