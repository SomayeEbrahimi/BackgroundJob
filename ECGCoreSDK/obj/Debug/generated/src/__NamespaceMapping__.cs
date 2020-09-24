using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.vivalnk.sdk", Managed="Com.Vivalnk.Sdk")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.vivalnk.sdk.aspectj.eventbus", Managed="Com.Vivalnk.Sdk.Aspectj.Eventbus")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.vivalnk.sdk.base", Managed="Com.Vivalnk.Sdk.Base")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.vivalnk.sdk.base.connect", Managed="Com.Vivalnk.Sdk.Base.Connect")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.vivalnk.sdk.ble", Managed="Com.Vivalnk.Sdk.Ble")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.vivalnk.sdk.ble.channel", Managed="Com.Vivalnk.Sdk.Ble.Channel")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.vivalnk.sdk.ble.ota", Managed="Com.Vivalnk.Sdk.Ble.Ota")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.vivalnk.sdk.command.base", Managed="Com.Vivalnk.Sdk.Command.Base")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.vivalnk.sdk.constant", Managed="Com.Vivalnk.Sdk.Constant")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.vivalnk.sdk.core", Managed="Com.Vivalnk.Sdk.Core")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.vivalnk.sdk.core.audio", Managed="Com.Vivalnk.Sdk.Core.Audio")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.vivalnk.sdk.core.baseline", Managed="Com.Vivalnk.Sdk.Core.Baseline")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.vivalnk.sdk.core.bp", Managed="Com.Vivalnk.Sdk.Core.BP")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.vivalnk.sdk.core.hr", Managed="Com.Vivalnk.Sdk.Core.HR")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.vivalnk.sdk.core.rr", Managed="Com.Vivalnk.Sdk.Core.RR")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.vivalnk.sdk.data", Managed="Com.Vivalnk.Sdk.Data")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.vivalnk.sdk.data.stream.afib", Managed="Com.Vivalnk.Sdk.Data.Stream.Afib")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.vivalnk.sdk.data.stream.packagelost", Managed="Com.Vivalnk.Sdk.Data.Stream.Packagelost")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.vivalnk.sdk.dataparser.battery", Managed="Com.Vivalnk.Sdk.Dataparser.Battery")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.vivalnk.sdk.dataparser.vv330", Managed="Com.Vivalnk.Sdk.Dataparser.Vv330")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.vivalnk.sdk.model", Managed="Com.Vivalnk.Sdk.Model")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.vivalnk.sdk.model.common", Managed="Com.Vivalnk.Sdk.Model.Common")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.vivalnk.sdk.open", Managed="Com.Vivalnk.Sdk.Open")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.vivalnk.sdk.report", Managed="Com.Vivalnk.Sdk.Report")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.vivalnk.sdk.repository.device", Managed="Com.Vivalnk.Sdk.Repository.Device")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.vivalnk.sdk.repository.local.database", Managed="Com.Vivalnk.Sdk.Repository.Local.Database")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.vivalnk.sdk.repository.local.database.convert", Managed="Com.Vivalnk.Sdk.Repository.Local.Database.Convert")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.vivalnk.sdk.repository.local.database.objectbox", Managed="Com.Vivalnk.Sdk.Repository.Local.Database.Objectbox")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.vivalnk.sdk.repository.local.database.room", Managed="Com.Vivalnk.Sdk.Repository.Local.Database.Room")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.vivalnk.sdk.repository.model", Managed="Com.Vivalnk.Sdk.Repository.Model")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.vivalnk.sdk.repository.model.event", Managed="Com.Vivalnk.Sdk.Repository.Model.Event")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.vivalnk.sdk.utils", Managed="Com.Vivalnk.Sdk.Utils")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.vivalnk.sdk.vital.ete", Managed="Com.Vivalnk.Sdk.Vital.Ete")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "fi.firstbeat.ete", Managed="FI.Firstbeat.Ete")]

delegate double _JniMarshal_PP_D (IntPtr jnienv, IntPtr klass);
delegate float _JniMarshal_PP_F (IntPtr jnienv, IntPtr klass);
delegate int _JniMarshal_PP_I (IntPtr jnienv, IntPtr klass);
delegate long _JniMarshal_PP_J (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PP_L (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PP_V (IntPtr jnienv, IntPtr klass);
delegate bool _JniMarshal_PP_Z (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PPBBL_L (IntPtr jnienv, IntPtr klass, sbyte p0, sbyte p1, IntPtr p2);
delegate void _JniMarshal_PPD_V (IntPtr jnienv, IntPtr klass, double p0);
delegate int _JniMarshal_PPI_I (IntPtr jnienv, IntPtr klass, int p0);
delegate IntPtr _JniMarshal_PPI_L (IntPtr jnienv, IntPtr klass, int p0);
delegate void _JniMarshal_PPI_V (IntPtr jnienv, IntPtr klass, int p0);
delegate bool _JniMarshal_PPI_Z (IntPtr jnienv, IntPtr klass, int p0);
delegate void _JniMarshal_PPII_V (IntPtr jnienv, IntPtr klass, int p0, int p1);
delegate void _JniMarshal_PPIIL_V (IntPtr jnienv, IntPtr klass, int p0, int p1, IntPtr p2);
delegate float _JniMarshal_PPIL_F (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1);
delegate void _JniMarshal_PPIL_V (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1);
delegate void _JniMarshal_PPILL_V (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1, IntPtr p2);
delegate void _JniMarshal_PPILLL_V (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1, IntPtr p2, IntPtr p3);
delegate IntPtr _JniMarshal_PPJ_L (IntPtr jnienv, IntPtr klass, long p0);
delegate void _JniMarshal_PPJ_V (IntPtr jnienv, IntPtr klass, long p0);
delegate int _JniMarshal_PPJLLZ_I (IntPtr jnienv, IntPtr klass, long p0, IntPtr p1, IntPtr p2, bool p3);
delegate int _JniMarshal_PPJLLZZ_I (IntPtr jnienv, IntPtr klass, long p0, IntPtr p1, IntPtr p2, bool p3, bool p4);
delegate int _JniMarshal_PPJLLZZI_I (IntPtr jnienv, IntPtr klass, long p0, IntPtr p1, IntPtr p2, bool p3, bool p4, int p5);
delegate int _JniMarshal_PPL_I (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate long _JniMarshal_PPL_J (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate IntPtr _JniMarshal_PPL_L (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPL_V (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate bool _JniMarshal_PPL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate int _JniMarshal_PPLI_I (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
delegate bool _JniMarshal_PPLI_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
delegate IntPtr _JniMarshal_PPLJ_L (IntPtr jnienv, IntPtr klass, IntPtr p0, long p1);
delegate IntPtr _JniMarshal_PPLJJ_L (IntPtr jnienv, IntPtr klass, IntPtr p0, long p1, long p2);
delegate IntPtr _JniMarshal_PPLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate void _JniMarshal_PPLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate void _JniMarshal_PPLLI_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, int p2);
delegate bool _JniMarshal_PPLLI_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, int p2);
delegate IntPtr _JniMarshal_PPLLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
delegate void _JniMarshal_PPLLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
delegate bool _JniMarshal_PPLLL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
delegate IntPtr _JniMarshal_PPZ_L (IntPtr jnienv, IntPtr klass, bool p0);
delegate void _JniMarshal_PPZ_V (IntPtr jnienv, IntPtr klass, bool p0);
delegate void _JniMarshal_PPZJ_V (IntPtr jnienv, IntPtr klass, bool p0, long p1);
