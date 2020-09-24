using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.vivalnk.model", Managed="Com.Vivalnk.Model")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.vivalnk.vdireader", Managed="Com.Vivalnk.Vdireader")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.vivalnk.vdireaderimpl", Managed="Com.Vivalnk.Vdireaderimpl")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.vivalnk.vdiutility", Managed="Com.Vivalnk.Vdiutility")]

delegate float _JniMarshal_PP_F (IntPtr jnienv, IntPtr klass);
delegate int _JniMarshal_PP_I (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PP_L (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PP_V (IntPtr jnienv, IntPtr klass);
delegate bool _JniMarshal_PP_Z (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PPF_V (IntPtr jnienv, IntPtr klass, float p0);
delegate void _JniMarshal_PPI_V (IntPtr jnienv, IntPtr klass, int p0);
delegate IntPtr _JniMarshal_PPL_L (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPL_V (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate bool _JniMarshal_PPL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPLIL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, IntPtr p2);
delegate void _JniMarshal_PPLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate bool _JniMarshal_PPLL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
