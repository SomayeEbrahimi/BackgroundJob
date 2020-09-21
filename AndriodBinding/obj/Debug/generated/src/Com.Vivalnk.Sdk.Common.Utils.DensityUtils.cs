using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='DensityUtils']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/DensityUtils", DoNotGenerateAcw=true)]
	public partial class DensityUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/utils/DensityUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DensityUtils); }
		}

		protected DensityUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='DensityUtils']/constructor[@name='DensityUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DensityUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DensityUtils)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_dip2px_Landroid_content_Context_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='DensityUtils']/method[@name='dip2px' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='float']]"
		[Register ("dip2px", "(Landroid/content/Context;F)I", "")]
		public static unsafe int Dip2px (global::Android.Content.Context context, float dpValue)
		{
			if (id_dip2px_Landroid_content_Context_F == IntPtr.Zero)
				id_dip2px_Landroid_content_Context_F = JNIEnv.GetStaticMethodID (class_ref, "dip2px", "(Landroid/content/Context;F)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (dpValue);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_dip2px_Landroid_content_Context_F, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_pt2Px_Landroid_content_Context_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='DensityUtils']/method[@name='pt2Px' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='float']]"
		[Register ("pt2Px", "(Landroid/content/Context;F)I", "")]
		public static unsafe int Pt2Px (global::Android.Content.Context context, float ptValue)
		{
			if (id_pt2Px_Landroid_content_Context_F == IntPtr.Zero)
				id_pt2Px_Landroid_content_Context_F = JNIEnv.GetStaticMethodID (class_ref, "pt2Px", "(Landroid/content/Context;F)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (ptValue);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_pt2Px_Landroid_content_Context_F, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_px2Pt_Landroid_content_Context_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='DensityUtils']/method[@name='px2Pt' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='float']]"
		[Register ("px2Pt", "(Landroid/content/Context;F)I", "")]
		public static unsafe int Px2Pt (global::Android.Content.Context context, float pxValue)
		{
			if (id_px2Pt_Landroid_content_Context_F == IntPtr.Zero)
				id_px2Pt_Landroid_content_Context_F = JNIEnv.GetStaticMethodID (class_ref, "px2Pt", "(Landroid/content/Context;F)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (pxValue);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_px2Pt_Landroid_content_Context_F, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_px2dip_Landroid_content_Context_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='DensityUtils']/method[@name='px2dip' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='float']]"
		[Register ("px2dip", "(Landroid/content/Context;F)I", "")]
		public static unsafe int Px2dip (global::Android.Content.Context context, float pxValue)
		{
			if (id_px2dip_Landroid_content_Context_F == IntPtr.Zero)
				id_px2dip_Landroid_content_Context_F = JNIEnv.GetStaticMethodID (class_ref, "px2dip", "(Landroid/content/Context;F)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (pxValue);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_px2dip_Landroid_content_Context_F, __args);
				return __ret;
			} finally {
			}
		}

	}
}
