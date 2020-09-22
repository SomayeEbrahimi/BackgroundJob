using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Concurrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='Memoizer']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/concurrent/Memoizer", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"I", "O"})]
	public partial class Memoizer : global::Java.Lang.Object, global::Org.Apache.Commons.Lang3.Concurrent.IComputable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/concurrent/Memoizer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Memoizer); }
		}

		protected Memoizer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_apache_commons_lang3_concurrent_Computable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='Memoizer']/constructor[@name='Memoizer' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.concurrent.Computable&lt;I, O&gt;']]"
		[Register (".ctor", "(Lorg/apache/commons/lang3/concurrent/Computable;)V", "")]
		public unsafe Memoizer (global::Org.Apache.Commons.Lang3.Concurrent.IComputable computable)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (computable);
				if (((object) this).GetType () != typeof (Memoizer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/apache/commons/lang3/concurrent/Computable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/apache/commons/lang3/concurrent/Computable;)V", __args);
					return;
				}

				if (id_ctor_Lorg_apache_commons_lang3_concurrent_Computable_ == IntPtr.Zero)
					id_ctor_Lorg_apache_commons_lang3_concurrent_Computable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/apache/commons/lang3/concurrent/Computable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_apache_commons_lang3_concurrent_Computable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_apache_commons_lang3_concurrent_Computable_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lorg_apache_commons_lang3_concurrent_Computable_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='Memoizer']/constructor[@name='Memoizer' and count(parameter)=2 and parameter[1][@type='org.apache.commons.lang3.concurrent.Computable&lt;I, O&gt;'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Lorg/apache/commons/lang3/concurrent/Computable;Z)V", "")]
		public unsafe Memoizer (global::Org.Apache.Commons.Lang3.Concurrent.IComputable computable, bool recalculate)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (computable);
				__args [1] = new JValue (recalculate);
				if (((object) this).GetType () != typeof (Memoizer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/apache/commons/lang3/concurrent/Computable;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/apache/commons/lang3/concurrent/Computable;Z)V", __args);
					return;
				}

				if (id_ctor_Lorg_apache_commons_lang3_concurrent_Computable_Z == IntPtr.Zero)
					id_ctor_Lorg_apache_commons_lang3_concurrent_Computable_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/apache/commons/lang3/concurrent/Computable;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_apache_commons_lang3_concurrent_Computable_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_apache_commons_lang3_concurrent_Computable_Z, __args);
			} finally {
			}
		}

		static Delegate cb_compute_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCompute_Ljava_lang_Object_Handler ()
		{
			if (cb_compute_Ljava_lang_Object_ == null)
				cb_compute_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Compute_Ljava_lang_Object_);
			return cb_compute_Ljava_lang_Object_;
		}

		static IntPtr n_Compute_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_arg)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.Memoizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var arg = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_arg, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Compute (arg));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compute_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='Memoizer']/method[@name='compute' and count(parameter)=1 and parameter[1][@type='I']]"
		[Register ("compute", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetCompute_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object Compute (global::Java.Lang.Object arg)
		{
			if (id_compute_Ljava_lang_Object_ == IntPtr.Zero)
				id_compute_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "compute", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_arg = JNIEnv.ToLocalJniHandle (arg);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_arg);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_compute_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compute", "(Ljava/lang/Object;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_arg);
			}
		}

	}
}
