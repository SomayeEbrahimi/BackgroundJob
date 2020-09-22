using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='BackpressureHelper']"
	[global::Android.Runtime.Register ("io/reactivex/internal/util/BackpressureHelper", DoNotGenerateAcw=true)]
	public sealed partial class BackpressureHelper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/util/BackpressureHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BackpressureHelper); }
		}

		internal BackpressureHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_add_Ljava_util_concurrent_atomic_AtomicLong_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='BackpressureHelper']/method[@name='add' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.atomic.AtomicLong'] and parameter[2][@type='long']]"
		[Register ("add", "(Ljava/util/concurrent/atomic/AtomicLong;J)J", "")]
		public static unsafe long Add (global::Java.Util.Concurrent.Atomic.AtomicLong requested, long n)
		{
			if (id_add_Ljava_util_concurrent_atomic_AtomicLong_J == IntPtr.Zero)
				id_add_Ljava_util_concurrent_atomic_AtomicLong_J = JNIEnv.GetStaticMethodID (class_ref, "add", "(Ljava/util/concurrent/atomic/AtomicLong;J)J");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (requested);
				__args [1] = new JValue (n);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_add_Ljava_util_concurrent_atomic_AtomicLong_J, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_addCancel_Ljava_util_concurrent_atomic_AtomicLong_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='BackpressureHelper']/method[@name='addCancel' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.atomic.AtomicLong'] and parameter[2][@type='long']]"
		[Register ("addCancel", "(Ljava/util/concurrent/atomic/AtomicLong;J)J", "")]
		public static unsafe long AddCancel (global::Java.Util.Concurrent.Atomic.AtomicLong requested, long n)
		{
			if (id_addCancel_Ljava_util_concurrent_atomic_AtomicLong_J == IntPtr.Zero)
				id_addCancel_Ljava_util_concurrent_atomic_AtomicLong_J = JNIEnv.GetStaticMethodID (class_ref, "addCancel", "(Ljava/util/concurrent/atomic/AtomicLong;J)J");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (requested);
				__args [1] = new JValue (n);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_addCancel_Ljava_util_concurrent_atomic_AtomicLong_J, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_addCap_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='BackpressureHelper']/method[@name='addCap' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("addCap", "(JJ)J", "")]
		public static unsafe long AddCap (long a, long b)
		{
			if (id_addCap_JJ == IntPtr.Zero)
				id_addCap_JJ = JNIEnv.GetStaticMethodID (class_ref, "addCap", "(JJ)J");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (a);
				__args [1] = new JValue (b);
				return JNIEnv.CallStaticLongMethod  (class_ref, id_addCap_JJ, __args);
			} finally {
			}
		}

		static IntPtr id_multiplyCap_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='BackpressureHelper']/method[@name='multiplyCap' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("multiplyCap", "(JJ)J", "")]
		public static unsafe long MultiplyCap (long a, long b)
		{
			if (id_multiplyCap_JJ == IntPtr.Zero)
				id_multiplyCap_JJ = JNIEnv.GetStaticMethodID (class_ref, "multiplyCap", "(JJ)J");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (a);
				__args [1] = new JValue (b);
				return JNIEnv.CallStaticLongMethod  (class_ref, id_multiplyCap_JJ, __args);
			} finally {
			}
		}

		static IntPtr id_produced_Ljava_util_concurrent_atomic_AtomicLong_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='BackpressureHelper']/method[@name='produced' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.atomic.AtomicLong'] and parameter[2][@type='long']]"
		[Register ("produced", "(Ljava/util/concurrent/atomic/AtomicLong;J)J", "")]
		public static unsafe long Produced (global::Java.Util.Concurrent.Atomic.AtomicLong requested, long n)
		{
			if (id_produced_Ljava_util_concurrent_atomic_AtomicLong_J == IntPtr.Zero)
				id_produced_Ljava_util_concurrent_atomic_AtomicLong_J = JNIEnv.GetStaticMethodID (class_ref, "produced", "(Ljava/util/concurrent/atomic/AtomicLong;J)J");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (requested);
				__args [1] = new JValue (n);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_produced_Ljava_util_concurrent_atomic_AtomicLong_J, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_producedCancel_Ljava_util_concurrent_atomic_AtomicLong_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='BackpressureHelper']/method[@name='producedCancel' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.atomic.AtomicLong'] and parameter[2][@type='long']]"
		[Register ("producedCancel", "(Ljava/util/concurrent/atomic/AtomicLong;J)J", "")]
		public static unsafe long ProducedCancel (global::Java.Util.Concurrent.Atomic.AtomicLong requested, long n)
		{
			if (id_producedCancel_Ljava_util_concurrent_atomic_AtomicLong_J == IntPtr.Zero)
				id_producedCancel_Ljava_util_concurrent_atomic_AtomicLong_J = JNIEnv.GetStaticMethodID (class_ref, "producedCancel", "(Ljava/util/concurrent/atomic/AtomicLong;J)J");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (requested);
				__args [1] = new JValue (n);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_producedCancel_Ljava_util_concurrent_atomic_AtomicLong_J, __args);
				return __ret;
			} finally {
			}
		}

	}
}
