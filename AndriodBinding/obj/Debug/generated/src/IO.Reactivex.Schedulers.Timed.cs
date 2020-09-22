using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Schedulers {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.schedulers']/class[@name='Timed']"
	[global::Android.Runtime.Register ("io/reactivex/schedulers/Timed", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class Timed : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/schedulers/Timed", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Timed); }
		}

		internal Timed (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.schedulers']/class[@name='Timed']/constructor[@name='Timed' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit']]"
		[Register (".ctor", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)V", "")]
		public unsafe Timed (global::Java.Lang.Object value, long time, global::Java.Util.Concurrent.TimeUnit unit)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_value);
				__args [1] = new JValue (time);
				__args [2] = new JValue (unit);
				if (((object) this).GetType () != typeof (Timed)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_time;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.schedulers']/class[@name='Timed']/method[@name='time' and count(parameter)=0]"
		[Register ("time", "()J", "")]
		public unsafe long Time ()
		{
			if (id_time == IntPtr.Zero)
				id_time = JNIEnv.GetMethodID (class_ref, "time", "()J");
			try {
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_time);
			} finally {
			}
		}

		static IntPtr id_time_Ljava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.schedulers']/class[@name='Timed']/method[@name='time' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.TimeUnit']]"
		[Register ("time", "(Ljava/util/concurrent/TimeUnit;)J", "")]
		public unsafe long Time (global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_time_Ljava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_time_Ljava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "time", "(Ljava/util/concurrent/TimeUnit;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (unit);
				long __ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_time_Ljava_util_concurrent_TimeUnit_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_unit;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.schedulers']/class[@name='Timed']/method[@name='unit' and count(parameter)=0]"
		[Register ("unit", "()Ljava/util/concurrent/TimeUnit;", "")]
		public unsafe global::Java.Util.Concurrent.TimeUnit Unit ()
		{
			if (id_unit == IntPtr.Zero)
				id_unit = JNIEnv.GetMethodID (class_ref, "unit", "()Ljava/util/concurrent/TimeUnit;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_unit), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_value;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.schedulers']/class[@name='Timed']/method[@name='value' and count(parameter)=0]"
		[Register ("value", "()Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object Value ()
		{
			if (id_value == IntPtr.Zero)
				id_value = JNIEnv.GetMethodID (class_ref, "value", "()Ljava/lang/Object;");
			try {
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_value), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
