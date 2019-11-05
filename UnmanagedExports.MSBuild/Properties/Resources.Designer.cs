// Decompiled with JetBrains decompiler
// Type: UnmanagedExports.MSBuild.Properties.Resources
// Assembly: UnmanagedExports.MSBuild, Version=1.2.7.38851, Culture=neutral, PublicKeyToken=8f52d83c1a22df51
// MVID: 94CA1E2E-92CF-42B1-82E4-1A993050CA42
// Assembly location: C:\Users\k.gosse\.nuget\packages\unmanagedexports.repack\1.0.0\tasks\UnmanagedExports.MSBuild.dll

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace UnmanagedExports.MSBuild.Properties
{
  [DebuggerNonUserCode]
  [CompilerGenerated]
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  public class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public static ResourceManager ResourceManager
    {
      get
      {
        if (object.ReferenceEquals((object) UnmanagedExports.MSBuild.Properties.Resources.resourceMan, (object) null))
          UnmanagedExports.MSBuild.Properties.Resources.resourceMan = new ResourceManager("UnmanagedExports.MSBuild.Properties.Resources", typeof (UnmanagedExports.MSBuild.Properties.Resources).Assembly);
        return UnmanagedExports.MSBuild.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public static CultureInfo Culture
    {
      get
      {
        return UnmanagedExports.MSBuild.Properties.Resources.resourceCulture;
      }
      set
      {
        UnmanagedExports.MSBuild.Properties.Resources.resourceCulture = value;
      }
    }

    public static string AssemblyRedirection_for_0_has_not_been_setup_
    {
      get
      {
        return UnmanagedExports.MSBuild.Properties.Resources.ResourceManager.GetString(nameof (AssemblyRedirection_for_0_has_not_been_setup_), UnmanagedExports.MSBuild.Properties.Resources.resourceCulture);
      }
    }

    public static string Both_key_values_KeyContainer_0_and_KeyFile_0_are_present_only_one_can_be_specified
    {
      get
      {
        return UnmanagedExports.MSBuild.Properties.Resources.ResourceManager.GetString(nameof (Both_key_values_KeyContainer_0_and_KeyFile_0_are_present_only_one_can_be_specified), UnmanagedExports.MSBuild.Properties.Resources.resourceCulture);
      }
    }

    public static string Cannot_find_ilasm_exe_in_0_
    {
      get
      {
        return UnmanagedExports.MSBuild.Properties.Resources.ResourceManager.GetString(nameof (Cannot_find_ilasm_exe_in_0_), UnmanagedExports.MSBuild.Properties.Resources.resourceCulture);
      }
    }

    public static string Cannot_find_ilasm_exe_without_a_FrameworkPath
    {
      get
      {
        return UnmanagedExports.MSBuild.Properties.Resources.ResourceManager.GetString(nameof (Cannot_find_ilasm_exe_without_a_FrameworkPath), UnmanagedExports.MSBuild.Properties.Resources.resourceCulture);
      }
    }

    public static string Cannot_find_lib_exe_in_0_
    {
      get
      {
        return UnmanagedExports.MSBuild.Properties.Resources.ResourceManager.GetString(nameof (Cannot_find_lib_exe_in_0_), UnmanagedExports.MSBuild.Properties.Resources.resourceCulture);
      }
    }

    public static string Cannot_get_a_reference_to_ToolLocationHelper
    {
      get
      {
        return UnmanagedExports.MSBuild.Properties.Resources.ResourceManager.GetString(nameof (Cannot_get_a_reference_to_ToolLocationHelper), UnmanagedExports.MSBuild.Properties.Resources.resourceCulture);
      }
    }

    public static string Input_file_0_does_not_exist__cannot_create_unmanaged_exports
    {
      get
      {
        return UnmanagedExports.MSBuild.Properties.Resources.ResourceManager.GetString(nameof (Input_file_0_does_not_exist__cannot_create_unmanaged_exports), UnmanagedExports.MSBuild.Properties.Resources.resourceCulture);
      }
    }

    public static string Input_file_0_is_not_a_DLL_hint
    {
      get
      {
        return UnmanagedExports.MSBuild.Properties.Resources.ResourceManager.GetString(nameof (Input_file_0_is_not_a_DLL_hint), UnmanagedExports.MSBuild.Properties.Resources.resourceCulture);
      }
    }

    public static string Input_file_is_empty__cannot_create_unmanaged_exports
    {
      get
      {
        return UnmanagedExports.MSBuild.Properties.Resources.ResourceManager.GetString(nameof (Input_file_is_empty__cannot_create_unmanaged_exports), UnmanagedExports.MSBuild.Properties.Resources.resourceCulture);
      }
    }

    public static string Output_assembly_was_signed_however_neither_keyfile_nor_keycontainer_could_be_inferred__Reading_those_values_from_assembly_attributes_is_not__yet__supported__they_have_to_be_defined_inside_the_MSBuild_project_file
    {
      get
      {
        return UnmanagedExports.MSBuild.Properties.Resources.ResourceManager.GetString(nameof (Output_assembly_was_signed_however_neither_keyfile_nor_keycontainer_could_be_inferred__Reading_those_values_from_assembly_attributes_is_not__yet__supported__they_have_to_be_defined_inside_the_MSBuild_project_file), UnmanagedExports.MSBuild.Properties.Resources.resourceCulture);
      }
    }

    public static string SdkPath_is_empty_continuing_with_0_
    {
      get
      {
        return UnmanagedExports.MSBuild.Properties.Resources.ResourceManager.GetString(nameof (SdkPath_is_empty_continuing_with_0_), UnmanagedExports.MSBuild.Properties.Resources.resourceCulture);
      }
    }

    public static string Skipped_Method_Exports
    {
      get
      {
        return UnmanagedExports.MSBuild.Properties.Resources.ResourceManager.GetString(nameof (Skipped_Method_Exports), UnmanagedExports.MSBuild.Properties.Resources.resourceCulture);
      }
    }

    public static string ToolLocationHelperTypeName_could_not_find_1
    {
      get
      {
        return UnmanagedExports.MSBuild.Properties.Resources.ResourceManager.GetString(nameof (ToolLocationHelperTypeName_could_not_find_1), UnmanagedExports.MSBuild.Properties.Resources.resourceCulture);
      }
    }
  }
}
