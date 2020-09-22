using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Event {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.event']/class[@name='EventUtils']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/event/EventUtils", DoNotGenerateAcw=true)]
	public partial class EventUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/event/EventUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EventUtils); }
		}

		protected EventUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.event']/class[@name='EventUtils']/constructor[@name='EventUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EventUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (EventUtils)) {
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

		static IntPtr id_addEventListener_Ljava_lang_Object_Ljava_lang_Class_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.event']/class[@name='EventUtils']/method[@name='addEventListener' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Class&lt;L&gt;'] and parameter[3][@type='L']]"
		[Register ("addEventListener", "(Ljava/lang/Object;Ljava/lang/Class;Ljava/lang/Object;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"L"})]
		public static unsafe void AddEventListener (global::Java.Lang.Object eventSource, global::Java.Lang.Class listenerType, global::Java.Lang.Object listener)
		{
			if (id_addEventListener_Ljava_lang_Object_Ljava_lang_Class_Ljava_lang_Object_ == IntPtr.Zero)
				id_addEventListener_Ljava_lang_Object_Ljava_lang_Class_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "addEventListener", "(Ljava/lang/Object;Ljava/lang/Class;Ljava/lang/Object;)V");
			IntPtr native_listener = JNIEnv.ToLocalJniHandle (listener);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (eventSource);
				__args [1] = new JValue (listenerType);
				__args [2] = new JValue (native_listener);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_addEventListener_Ljava_lang_Object_Ljava_lang_Class_Ljava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_listener);
			}
		}

		static IntPtr id_bindEventsToMethod_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Class_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.event']/class[@name='EventUtils']/method[@name='bindEventsToMethod' and count(parameter)=5 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='java.lang.Class&lt;L&gt;'] and parameter[5][@type='java.lang.String...']]"
		[Register ("bindEventsToMethod", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Class;[Ljava/lang/String;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"L"})]
		public static unsafe void BindEventsToMethod (global::Java.Lang.Object target, string methodName, global::Java.Lang.Object eventSource, global::Java.Lang.Class listenerType, params string[] eventTypes)
		{
			if (id_bindEventsToMethod_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Class_arrayLjava_lang_String_ == IntPtr.Zero)
				id_bindEventsToMethod_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Class_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "bindEventsToMethod", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Class;[Ljava/lang/String;)V");
			IntPtr native_methodName = JNIEnv.NewString (methodName);
			IntPtr native_eventTypes = JNIEnv.NewArray (eventTypes);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (target);
				__args [1] = new JValue (native_methodName);
				__args [2] = new JValue (eventSource);
				__args [3] = new JValue (listenerType);
				__args [4] = new JValue (native_eventTypes);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_bindEventsToMethod_Ljava_lang_Object_Ljava_lang_String_Ljava_lang_Object_Ljava_lang_Class_arrayLjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_methodName);
				if (eventTypes != null) {
					JNIEnv.CopyArray (native_eventTypes, eventTypes);
					JNIEnv.DeleteLocalRef (native_eventTypes);
				}
			}
		}

	}
}
