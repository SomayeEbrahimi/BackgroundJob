using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ThreadUtils']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/ThreadUtils", DoNotGenerateAcw=true)]
	public partial class ThreadUtils : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ThreadUtils.NamePredicate']"
		[global::Android.Runtime.Register ("org/apache/commons/lang3/ThreadUtils$NamePredicate", DoNotGenerateAcw=true)]
		public partial class NamePredicate : global::Java.Lang.Object, global::Org.Apache.Commons.Lang3.ThreadUtils.IThreadGroupPredicate, global::Org.Apache.Commons.Lang3.ThreadUtils.IThreadPredicate {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/apache/commons/lang3/ThreadUtils$NamePredicate", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (NamePredicate); }
			}

			protected NamePredicate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ThreadUtils.NamePredicate']/constructor[@name='ThreadUtils.NamePredicate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe NamePredicate (string name)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					if (((object) this).GetType () != typeof (NamePredicate)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static Delegate cb_test_Ljava_lang_Thread_;
#pragma warning disable 0169
			static Delegate GetTest_Ljava_lang_Thread_Handler ()
			{
				if (cb_test_Ljava_lang_Thread_ == null)
					cb_test_Ljava_lang_Thread_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Test_Ljava_lang_Thread_);
				return cb_test_Ljava_lang_Thread_;
			}

			static bool n_Test_Ljava_lang_Thread_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.ThreadUtils.NamePredicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (native_thread, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Test (thread);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_test_Ljava_lang_Thread_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ThreadUtils.NamePredicate']/method[@name='test' and count(parameter)=1 and parameter[1][@type='java.lang.Thread']]"
			[Register ("test", "(Ljava/lang/Thread;)Z", "GetTest_Ljava_lang_Thread_Handler")]
			public virtual unsafe bool Test (global::Java.Lang.Thread thread)
			{
				if (id_test_Ljava_lang_Thread_ == IntPtr.Zero)
					id_test_Ljava_lang_Thread_ = JNIEnv.GetMethodID (class_ref, "test", "(Ljava/lang/Thread;)Z");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (thread);

					bool __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_test_Ljava_lang_Thread_, __args);
					else
						__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "test", "(Ljava/lang/Thread;)Z"), __args);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_test_Ljava_lang_ThreadGroup_;
#pragma warning disable 0169
			static Delegate GetTest_Ljava_lang_ThreadGroup_Handler ()
			{
				if (cb_test_Ljava_lang_ThreadGroup_ == null)
					cb_test_Ljava_lang_ThreadGroup_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Test_Ljava_lang_ThreadGroup_);
				return cb_test_Ljava_lang_ThreadGroup_;
			}

			static bool n_Test_Ljava_lang_ThreadGroup_ (IntPtr jnienv, IntPtr native__this, IntPtr native_threadGroup)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.ThreadUtils.NamePredicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var threadGroup = global::Java.Lang.Object.GetObject<global::Java.Lang.ThreadGroup> (native_threadGroup, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Test (threadGroup);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_test_Ljava_lang_ThreadGroup_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ThreadUtils.NamePredicate']/method[@name='test' and count(parameter)=1 and parameter[1][@type='java.lang.ThreadGroup']]"
			[Register ("test", "(Ljava/lang/ThreadGroup;)Z", "GetTest_Ljava_lang_ThreadGroup_Handler")]
			public virtual unsafe bool Test (global::Java.Lang.ThreadGroup threadGroup)
			{
				if (id_test_Ljava_lang_ThreadGroup_ == IntPtr.Zero)
					id_test_Ljava_lang_ThreadGroup_ = JNIEnv.GetMethodID (class_ref, "test", "(Ljava/lang/ThreadGroup;)Z");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (threadGroup);

					bool __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_test_Ljava_lang_ThreadGroup_, __args);
					else
						__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "test", "(Ljava/lang/ThreadGroup;)Z"), __args);
					return __ret;
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='org.apache.commons.lang3']/interface[@name='ThreadUtils.ThreadGroupPredicate']"
		[Register ("org/apache/commons/lang3/ThreadUtils$ThreadGroupPredicate", "", "Org.Apache.Commons.Lang3.ThreadUtils/IThreadGroupPredicateInvoker")]
		public partial interface IThreadGroupPredicate : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/interface[@name='ThreadUtils.ThreadGroupPredicate']/method[@name='test' and count(parameter)=1 and parameter[1][@type='java.lang.ThreadGroup']]"
			[Register ("test", "(Ljava/lang/ThreadGroup;)Z", "GetTest_Ljava_lang_ThreadGroup_Handler:Org.Apache.Commons.Lang3.ThreadUtils/IThreadGroupPredicateInvoker, AndriodBinding")]
			bool Test (global::Java.Lang.ThreadGroup p0);

		}

		[global::Android.Runtime.Register ("org/apache/commons/lang3/ThreadUtils$ThreadGroupPredicate", DoNotGenerateAcw=true)]
		internal partial class IThreadGroupPredicateInvoker : global::Java.Lang.Object, IThreadGroupPredicate {

			static IntPtr java_class_ref = JNIEnv.FindClass ("org/apache/commons/lang3/ThreadUtils$ThreadGroupPredicate");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IThreadGroupPredicateInvoker); }
			}

			IntPtr class_ref;

			public static IThreadGroupPredicate GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IThreadGroupPredicate> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.apache.commons.lang3.ThreadUtils.ThreadGroupPredicate"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IThreadGroupPredicateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_test_Ljava_lang_ThreadGroup_;
#pragma warning disable 0169
			static Delegate GetTest_Ljava_lang_ThreadGroup_Handler ()
			{
				if (cb_test_Ljava_lang_ThreadGroup_ == null)
					cb_test_Ljava_lang_ThreadGroup_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Test_Ljava_lang_ThreadGroup_);
				return cb_test_Ljava_lang_ThreadGroup_;
			}

			static bool n_Test_Ljava_lang_ThreadGroup_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.ThreadUtils.IThreadGroupPredicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ThreadGroup> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Test (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_test_Ljava_lang_ThreadGroup_;
			public unsafe bool Test (global::Java.Lang.ThreadGroup p0)
			{
				if (id_test_Ljava_lang_ThreadGroup_ == IntPtr.Zero)
					id_test_Ljava_lang_ThreadGroup_ = JNIEnv.GetMethodID (class_ref, "test", "(Ljava/lang/ThreadGroup;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_test_Ljava_lang_ThreadGroup_, __args);
				return __ret;
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ThreadUtils.ThreadIdPredicate']"
		[global::Android.Runtime.Register ("org/apache/commons/lang3/ThreadUtils$ThreadIdPredicate", DoNotGenerateAcw=true)]
		public partial class ThreadIdPredicate : global::Java.Lang.Object, global::Org.Apache.Commons.Lang3.ThreadUtils.IThreadPredicate {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/apache/commons/lang3/ThreadUtils$ThreadIdPredicate", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ThreadIdPredicate); }
			}

			protected ThreadIdPredicate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_J;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ThreadUtils.ThreadIdPredicate']/constructor[@name='ThreadUtils.ThreadIdPredicate' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register (".ctor", "(J)V", "")]
			public unsafe ThreadIdPredicate (long threadId)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (threadId);
					if (((object) this).GetType () != typeof (ThreadIdPredicate)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(J)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(J)V", __args);
						return;
					}

					if (id_ctor_J == IntPtr.Zero)
						id_ctor_J = JNIEnv.GetMethodID (class_ref, "<init>", "(J)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_J, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_J, __args);
				} finally {
				}
			}

			static Delegate cb_test_Ljava_lang_Thread_;
#pragma warning disable 0169
			static Delegate GetTest_Ljava_lang_Thread_Handler ()
			{
				if (cb_test_Ljava_lang_Thread_ == null)
					cb_test_Ljava_lang_Thread_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Test_Ljava_lang_Thread_);
				return cb_test_Ljava_lang_Thread_;
			}

			static bool n_Test_Ljava_lang_Thread_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.ThreadUtils.ThreadIdPredicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (native_thread, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Test (thread);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_test_Ljava_lang_Thread_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ThreadUtils.ThreadIdPredicate']/method[@name='test' and count(parameter)=1 and parameter[1][@type='java.lang.Thread']]"
			[Register ("test", "(Ljava/lang/Thread;)Z", "GetTest_Ljava_lang_Thread_Handler")]
			public virtual unsafe bool Test (global::Java.Lang.Thread thread)
			{
				if (id_test_Ljava_lang_Thread_ == IntPtr.Zero)
					id_test_Ljava_lang_Thread_ = JNIEnv.GetMethodID (class_ref, "test", "(Ljava/lang/Thread;)Z");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (thread);

					bool __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_test_Ljava_lang_Thread_, __args);
					else
						__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "test", "(Ljava/lang/Thread;)Z"), __args);
					return __ret;
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='org.apache.commons.lang3']/interface[@name='ThreadUtils.ThreadPredicate']"
		[Register ("org/apache/commons/lang3/ThreadUtils$ThreadPredicate", "", "Org.Apache.Commons.Lang3.ThreadUtils/IThreadPredicateInvoker")]
		public partial interface IThreadPredicate : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/interface[@name='ThreadUtils.ThreadPredicate']/method[@name='test' and count(parameter)=1 and parameter[1][@type='java.lang.Thread']]"
			[Register ("test", "(Ljava/lang/Thread;)Z", "GetTest_Ljava_lang_Thread_Handler:Org.Apache.Commons.Lang3.ThreadUtils/IThreadPredicateInvoker, AndriodBinding")]
			bool Test (global::Java.Lang.Thread p0);

		}

		[global::Android.Runtime.Register ("org/apache/commons/lang3/ThreadUtils$ThreadPredicate", DoNotGenerateAcw=true)]
		internal partial class IThreadPredicateInvoker : global::Java.Lang.Object, IThreadPredicate {

			static IntPtr java_class_ref = JNIEnv.FindClass ("org/apache/commons/lang3/ThreadUtils$ThreadPredicate");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IThreadPredicateInvoker); }
			}

			IntPtr class_ref;

			public static IThreadPredicate GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IThreadPredicate> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.apache.commons.lang3.ThreadUtils.ThreadPredicate"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IThreadPredicateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_test_Ljava_lang_Thread_;
#pragma warning disable 0169
			static Delegate GetTest_Ljava_lang_Thread_Handler ()
			{
				if (cb_test_Ljava_lang_Thread_ == null)
					cb_test_Ljava_lang_Thread_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Test_Ljava_lang_Thread_);
				return cb_test_Ljava_lang_Thread_;
			}

			static bool n_Test_Ljava_lang_Thread_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.ThreadUtils.IThreadPredicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Test (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_test_Ljava_lang_Thread_;
			public unsafe bool Test (global::Java.Lang.Thread p0)
			{
				if (id_test_Ljava_lang_Thread_ == IntPtr.Zero)
					id_test_Ljava_lang_Thread_ = JNIEnv.GetMethodID (class_ref, "test", "(Ljava/lang/Thread;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_test_Ljava_lang_Thread_, __args);
				return __ret;
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/ThreadUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ThreadUtils); }
		}

		protected ThreadUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ThreadUtils']/constructor[@name='ThreadUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ThreadUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ThreadUtils)) {
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

		static IntPtr id_getAllThreadGroups;
		public static unsafe global::System.Collections.Generic.ICollection<global::Java.Lang.ThreadGroup> AllThreadGroups {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ThreadUtils']/method[@name='getAllThreadGroups' and count(parameter)=0]"
			[Register ("getAllThreadGroups", "()Ljava/util/Collection;", "")]
			get {
				if (id_getAllThreadGroups == IntPtr.Zero)
					id_getAllThreadGroups = JNIEnv.GetStaticMethodID (class_ref, "getAllThreadGroups", "()Ljava/util/Collection;");
				try {
					return global::Android.Runtime.JavaCollection<global::Java.Lang.ThreadGroup>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAllThreadGroups), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getAllThreads;
		public static unsafe global::System.Collections.Generic.ICollection<global::Java.Lang.Thread> AllThreads {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ThreadUtils']/method[@name='getAllThreads' and count(parameter)=0]"
			[Register ("getAllThreads", "()Ljava/util/Collection;", "")]
			get {
				if (id_getAllThreads == IntPtr.Zero)
					id_getAllThreads = JNIEnv.GetStaticMethodID (class_ref, "getAllThreads", "()Ljava/util/Collection;");
				try {
					return global::Android.Runtime.JavaCollection<global::Java.Lang.Thread>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAllThreads), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSystemThreadGroup;
		public static unsafe global::Java.Lang.ThreadGroup SystemThreadGroup {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ThreadUtils']/method[@name='getSystemThreadGroup' and count(parameter)=0]"
			[Register ("getSystemThreadGroup", "()Ljava/lang/ThreadGroup;", "")]
			get {
				if (id_getSystemThreadGroup == IntPtr.Zero)
					id_getSystemThreadGroup = JNIEnv.GetStaticMethodID (class_ref, "getSystemThreadGroup", "()Ljava/lang/ThreadGroup;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.ThreadGroup> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSystemThreadGroup), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_findThreadById_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ThreadUtils']/method[@name='findThreadById' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("findThreadById", "(J)Ljava/lang/Thread;", "")]
		public static unsafe global::Java.Lang.Thread FindThreadById (long threadId)
		{
			if (id_findThreadById_J == IntPtr.Zero)
				id_findThreadById_J = JNIEnv.GetStaticMethodID (class_ref, "findThreadById", "(J)Ljava/lang/Thread;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (threadId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findThreadById_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_findThreadById_JLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ThreadUtils']/method[@name='findThreadById' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("findThreadById", "(JLjava/lang/String;)Ljava/lang/Thread;", "")]
		public static unsafe global::Java.Lang.Thread FindThreadById (long threadId, string threadGroupName)
		{
			if (id_findThreadById_JLjava_lang_String_ == IntPtr.Zero)
				id_findThreadById_JLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "findThreadById", "(JLjava/lang/String;)Ljava/lang/Thread;");
			IntPtr native_threadGroupName = JNIEnv.NewString (threadGroupName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (threadId);
				__args [1] = new JValue (native_threadGroupName);
				global::Java.Lang.Thread __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findThreadById_JLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_threadGroupName);
			}
		}

		static IntPtr id_findThreadById_JLjava_lang_ThreadGroup_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ThreadUtils']/method[@name='findThreadById' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.ThreadGroup']]"
		[Register ("findThreadById", "(JLjava/lang/ThreadGroup;)Ljava/lang/Thread;", "")]
		public static unsafe global::Java.Lang.Thread FindThreadById (long threadId, global::Java.Lang.ThreadGroup threadGroup)
		{
			if (id_findThreadById_JLjava_lang_ThreadGroup_ == IntPtr.Zero)
				id_findThreadById_JLjava_lang_ThreadGroup_ = JNIEnv.GetStaticMethodID (class_ref, "findThreadById", "(JLjava/lang/ThreadGroup;)Ljava/lang/Thread;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (threadId);
				__args [1] = new JValue (threadGroup);
				global::Java.Lang.Thread __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findThreadById_JLjava_lang_ThreadGroup_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_findThreadGroups_Ljava_lang_ThreadGroup_ZLorg_apache_commons_lang3_ThreadUtils_ThreadGroupPredicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ThreadUtils']/method[@name='findThreadGroups' and count(parameter)=3 and parameter[1][@type='java.lang.ThreadGroup'] and parameter[2][@type='boolean'] and parameter[3][@type='org.apache.commons.lang3.ThreadUtils.ThreadGroupPredicate']]"
		[Register ("findThreadGroups", "(Ljava/lang/ThreadGroup;ZLorg/apache/commons/lang3/ThreadUtils$ThreadGroupPredicate;)Ljava/util/Collection;", "")]
		public static unsafe global::System.Collections.Generic.ICollection<global::Java.Lang.ThreadGroup> FindThreadGroups (global::Java.Lang.ThreadGroup group, bool recurse, global::Org.Apache.Commons.Lang3.ThreadUtils.IThreadGroupPredicate predicate)
		{
			if (id_findThreadGroups_Ljava_lang_ThreadGroup_ZLorg_apache_commons_lang3_ThreadUtils_ThreadGroupPredicate_ == IntPtr.Zero)
				id_findThreadGroups_Ljava_lang_ThreadGroup_ZLorg_apache_commons_lang3_ThreadUtils_ThreadGroupPredicate_ = JNIEnv.GetStaticMethodID (class_ref, "findThreadGroups", "(Ljava/lang/ThreadGroup;ZLorg/apache/commons/lang3/ThreadUtils$ThreadGroupPredicate;)Ljava/util/Collection;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (group);
				__args [1] = new JValue (recurse);
				__args [2] = new JValue (predicate);
				global::System.Collections.Generic.ICollection<global::Java.Lang.ThreadGroup> __ret = global::Android.Runtime.JavaCollection<global::Java.Lang.ThreadGroup>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_findThreadGroups_Ljava_lang_ThreadGroup_ZLorg_apache_commons_lang3_ThreadUtils_ThreadGroupPredicate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_findThreadGroups_Lorg_apache_commons_lang3_ThreadUtils_ThreadGroupPredicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ThreadUtils']/method[@name='findThreadGroups' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.ThreadUtils.ThreadGroupPredicate']]"
		[Register ("findThreadGroups", "(Lorg/apache/commons/lang3/ThreadUtils$ThreadGroupPredicate;)Ljava/util/Collection;", "")]
		public static unsafe global::System.Collections.Generic.ICollection<global::Java.Lang.ThreadGroup> FindThreadGroups (global::Org.Apache.Commons.Lang3.ThreadUtils.IThreadGroupPredicate predicate)
		{
			if (id_findThreadGroups_Lorg_apache_commons_lang3_ThreadUtils_ThreadGroupPredicate_ == IntPtr.Zero)
				id_findThreadGroups_Lorg_apache_commons_lang3_ThreadUtils_ThreadGroupPredicate_ = JNIEnv.GetStaticMethodID (class_ref, "findThreadGroups", "(Lorg/apache/commons/lang3/ThreadUtils$ThreadGroupPredicate;)Ljava/util/Collection;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (predicate);
				global::System.Collections.Generic.ICollection<global::Java.Lang.ThreadGroup> __ret = global::Android.Runtime.JavaCollection<global::Java.Lang.ThreadGroup>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_findThreadGroups_Lorg_apache_commons_lang3_ThreadUtils_ThreadGroupPredicate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_findThreadGroupsByName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ThreadUtils']/method[@name='findThreadGroupsByName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("findThreadGroupsByName", "(Ljava/lang/String;)Ljava/util/Collection;", "")]
		public static unsafe global::System.Collections.Generic.ICollection<global::Java.Lang.ThreadGroup> FindThreadGroupsByName (string threadGroupName)
		{
			if (id_findThreadGroupsByName_Ljava_lang_String_ == IntPtr.Zero)
				id_findThreadGroupsByName_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "findThreadGroupsByName", "(Ljava/lang/String;)Ljava/util/Collection;");
			IntPtr native_threadGroupName = JNIEnv.NewString (threadGroupName);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_threadGroupName);
				global::System.Collections.Generic.ICollection<global::Java.Lang.ThreadGroup> __ret = global::Android.Runtime.JavaCollection<global::Java.Lang.ThreadGroup>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_findThreadGroupsByName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_threadGroupName);
			}
		}

		static IntPtr id_findThreads_Ljava_lang_ThreadGroup_ZLorg_apache_commons_lang3_ThreadUtils_ThreadPredicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ThreadUtils']/method[@name='findThreads' and count(parameter)=3 and parameter[1][@type='java.lang.ThreadGroup'] and parameter[2][@type='boolean'] and parameter[3][@type='org.apache.commons.lang3.ThreadUtils.ThreadPredicate']]"
		[Register ("findThreads", "(Ljava/lang/ThreadGroup;ZLorg/apache/commons/lang3/ThreadUtils$ThreadPredicate;)Ljava/util/Collection;", "")]
		public static unsafe global::System.Collections.Generic.ICollection<global::Java.Lang.Thread> FindThreads (global::Java.Lang.ThreadGroup group, bool recurse, global::Org.Apache.Commons.Lang3.ThreadUtils.IThreadPredicate predicate)
		{
			if (id_findThreads_Ljava_lang_ThreadGroup_ZLorg_apache_commons_lang3_ThreadUtils_ThreadPredicate_ == IntPtr.Zero)
				id_findThreads_Ljava_lang_ThreadGroup_ZLorg_apache_commons_lang3_ThreadUtils_ThreadPredicate_ = JNIEnv.GetStaticMethodID (class_ref, "findThreads", "(Ljava/lang/ThreadGroup;ZLorg/apache/commons/lang3/ThreadUtils$ThreadPredicate;)Ljava/util/Collection;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (group);
				__args [1] = new JValue (recurse);
				__args [2] = new JValue (predicate);
				global::System.Collections.Generic.ICollection<global::Java.Lang.Thread> __ret = global::Android.Runtime.JavaCollection<global::Java.Lang.Thread>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_findThreads_Ljava_lang_ThreadGroup_ZLorg_apache_commons_lang3_ThreadUtils_ThreadPredicate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_findThreads_Lorg_apache_commons_lang3_ThreadUtils_ThreadPredicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ThreadUtils']/method[@name='findThreads' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.ThreadUtils.ThreadPredicate']]"
		[Register ("findThreads", "(Lorg/apache/commons/lang3/ThreadUtils$ThreadPredicate;)Ljava/util/Collection;", "")]
		public static unsafe global::System.Collections.Generic.ICollection<global::Java.Lang.Thread> FindThreads (global::Org.Apache.Commons.Lang3.ThreadUtils.IThreadPredicate predicate)
		{
			if (id_findThreads_Lorg_apache_commons_lang3_ThreadUtils_ThreadPredicate_ == IntPtr.Zero)
				id_findThreads_Lorg_apache_commons_lang3_ThreadUtils_ThreadPredicate_ = JNIEnv.GetStaticMethodID (class_ref, "findThreads", "(Lorg/apache/commons/lang3/ThreadUtils$ThreadPredicate;)Ljava/util/Collection;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (predicate);
				global::System.Collections.Generic.ICollection<global::Java.Lang.Thread> __ret = global::Android.Runtime.JavaCollection<global::Java.Lang.Thread>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_findThreads_Lorg_apache_commons_lang3_ThreadUtils_ThreadPredicate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_findThreadsByName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ThreadUtils']/method[@name='findThreadsByName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("findThreadsByName", "(Ljava/lang/String;)Ljava/util/Collection;", "")]
		public static unsafe global::System.Collections.Generic.ICollection<global::Java.Lang.Thread> FindThreadsByName (string threadName)
		{
			if (id_findThreadsByName_Ljava_lang_String_ == IntPtr.Zero)
				id_findThreadsByName_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "findThreadsByName", "(Ljava/lang/String;)Ljava/util/Collection;");
			IntPtr native_threadName = JNIEnv.NewString (threadName);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_threadName);
				global::System.Collections.Generic.ICollection<global::Java.Lang.Thread> __ret = global::Android.Runtime.JavaCollection<global::Java.Lang.Thread>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_findThreadsByName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_threadName);
			}
		}

		static IntPtr id_findThreadsByName_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ThreadUtils']/method[@name='findThreadsByName' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("findThreadsByName", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/Collection;", "")]
		public static unsafe global::System.Collections.Generic.ICollection<global::Java.Lang.Thread> FindThreadsByName (string threadName, string threadGroupName)
		{
			if (id_findThreadsByName_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_findThreadsByName_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "findThreadsByName", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/Collection;");
			IntPtr native_threadName = JNIEnv.NewString (threadName);
			IntPtr native_threadGroupName = JNIEnv.NewString (threadGroupName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_threadName);
				__args [1] = new JValue (native_threadGroupName);
				global::System.Collections.Generic.ICollection<global::Java.Lang.Thread> __ret = global::Android.Runtime.JavaCollection<global::Java.Lang.Thread>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_findThreadsByName_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_threadName);
				JNIEnv.DeleteLocalRef (native_threadGroupName);
			}
		}

		static IntPtr id_findThreadsByName_Ljava_lang_String_Ljava_lang_ThreadGroup_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ThreadUtils']/method[@name='findThreadsByName' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.ThreadGroup']]"
		[Register ("findThreadsByName", "(Ljava/lang/String;Ljava/lang/ThreadGroup;)Ljava/util/Collection;", "")]
		public static unsafe global::System.Collections.Generic.ICollection<global::Java.Lang.Thread> FindThreadsByName (string threadName, global::Java.Lang.ThreadGroup threadGroup)
		{
			if (id_findThreadsByName_Ljava_lang_String_Ljava_lang_ThreadGroup_ == IntPtr.Zero)
				id_findThreadsByName_Ljava_lang_String_Ljava_lang_ThreadGroup_ = JNIEnv.GetStaticMethodID (class_ref, "findThreadsByName", "(Ljava/lang/String;Ljava/lang/ThreadGroup;)Ljava/util/Collection;");
			IntPtr native_threadName = JNIEnv.NewString (threadName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_threadName);
				__args [1] = new JValue (threadGroup);
				global::System.Collections.Generic.ICollection<global::Java.Lang.Thread> __ret = global::Android.Runtime.JavaCollection<global::Java.Lang.Thread>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_findThreadsByName_Ljava_lang_String_Ljava_lang_ThreadGroup_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_threadName);
			}
		}

	}
}
