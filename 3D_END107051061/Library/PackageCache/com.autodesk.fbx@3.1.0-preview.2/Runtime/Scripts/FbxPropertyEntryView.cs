//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Autodesk.Fbx {

public class FbxPropertyEntryView : FbxEntryView {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxPropertyEntryView(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NativeMethods.FbxPropertyEntryView_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxPropertyEntryView obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxPropertyEntryView() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NativeMethods.delete_FbxPropertyEntryView(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public FbxPropertyEntryView(FbxBindingTableEntry pEntry, bool pAsSource, bool pCreate) : this(NativeMethods.new_FbxPropertyEntryView__SWIG_0(FbxBindingTableEntry.getCPtr(pEntry), pAsSource, pCreate), true) {
  }

  public FbxPropertyEntryView(FbxBindingTableEntry pEntry, bool pAsSource) : this(NativeMethods.new_FbxPropertyEntryView__SWIG_1(FbxBindingTableEntry.getCPtr(pEntry), pAsSource), true) {
  }

  public string GetProperty() {
    string ret = NativeMethods.FbxPropertyEntryView_GetProperty(swigCPtr);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetProperty(string pPropertyName) {
    NativeMethods.FbxPropertyEntryView_SetProperty(swigCPtr, pPropertyName);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
  }

}

}
