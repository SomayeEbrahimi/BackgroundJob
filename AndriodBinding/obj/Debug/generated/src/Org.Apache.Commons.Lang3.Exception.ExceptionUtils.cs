using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Exception {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.exception']/class[@name='ExceptionUtils']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/exception/ExceptionUtils", DoNotGenerateAcw=true)]
	public partial class ExceptionUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/exception/ExceptionUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ExceptionUtils); }
		}

		protected ExceptionUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.exception']/class[@name='ExceptionUtils']/constructor[@name='ExceptionUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ExceptionUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ExceptionUtils)) {
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

		static IntPtr id_getCause_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.exception']/class[@name='ExceptionUtils']/method[@name='getCause' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Obsolete (@"deprecated")]
		[Register ("getCause", "(Ljava/lang/Throwable;)Ljava/lang/Throwable;", "")]
		public static unsafe global::Java.Lang.Throwable GetCause (global::Java.Lang.Throwable throwable)
		{
			if (id_getCause_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_getCause_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "getCause", "(Ljava/lang/Throwable;)Ljava/lang/Throwable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (throwable);
				global::Java.Lang.Throwable __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCause_Ljava_lang_Throwable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getCause_Ljava_lang_Throwable_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.exception']/class[@name='ExceptionUtils']/method[@name='getCause' and count(parameter)=2 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.String[]']]"
		[Obsolete (@"deprecated")]
		[Register ("getCause", "(Ljava/lang/Throwable;[Ljava/lang/String;)Ljava/lang/Throwable;", "")]
		public static unsafe global::Java.Lang.Throwable GetCause (global::Java.Lang.Throwable throwable, string[] methodNames)
		{
			if (id_getCause_Ljava_lang_Throwable_arrayLjava_lang_String_ == IntPtr.Zero)
				id_getCause_Ljava_lang_Throwable_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getCause", "(Ljava/lang/Throwable;[Ljava/lang/String;)Ljava/lang/Throwable;");
			IntPtr native_methodNames = JNIEnv.NewArray (methodNames);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (throwable);
				__args [1] = new JValue (native_methodNames);
				global::Java.Lang.Throwable __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCause_Ljava_lang_Throwable_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (methodNames != null) {
					JNIEnv.CopyArray (native_methodNames, methodNames);
					JNIEnv.DeleteLocalRef (native_methodNames);
				}
			}
		}

		static IntPtr id_getDefaultCauseMethodNames;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.exception']/class[@name='ExceptionUtils']/method[@name='getDefaultCauseMethodNames' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("getDefaultCauseMethodNames", "()[Ljava/lang/String;", "")]
		public static unsafe string[] GetDefaultCauseMethodNames ()
		{
			if (id_getDefaultCauseMethodNames == IntPtr.Zero)
				id_getDefaultCauseMethodNames = JNIEnv.GetStaticMethodID (class_ref, "getDefaultCauseMethodNames", "()[Ljava/lang/String;");
			try {
				return (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDefaultCauseMethodNames), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static IntPtr id_getMessage_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.exception']/class[@name='ExceptionUtils']/method[@name='getMessage' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("getMessage", "(Ljava/lang/Throwable;)Ljava/lang/String;", "")]
		public static unsafe string GetMessage (global::Java.Lang.Throwable th)
		{
			if (id_getMessage_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_getMessage_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "getMessage", "(Ljava/lang/Throwable;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (th);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMessage_Ljava_lang_Throwable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getRootCause_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.exception']/class[@name='ExceptionUtils']/method[@name='getRootCause' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("getRootCause", "(Ljava/lang/Throwable;)Ljava/lang/Throwable;", "")]
		public static unsafe global::Java.Lang.Throwable GetRootCause (global::Java.Lang.Throwable throwable)
		{
			if (id_getRootCause_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_getRootCause_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "getRootCause", "(Ljava/lang/Throwable;)Ljava/lang/Throwable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (throwable);
				global::Java.Lang.Throwable __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getRootCause_Ljava_lang_Throwable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getRootCauseMessage_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.exception']/class[@name='ExceptionUtils']/method[@name='getRootCauseMessage' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("getRootCauseMessage", "(Ljava/lang/Throwable;)Ljava/lang/String;", "")]
		public static unsafe string GetRootCauseMessage (global::Java.Lang.Throwable th)
		{
			if (id_getRootCauseMessage_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_getRootCauseMessage_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "getRootCauseMessage", "(Ljava/lang/Throwable;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (th);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getRootCauseMessage_Ljava_lang_Throwable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getRootCauseStackTrace_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.exception']/class[@name='ExceptionUtils']/method[@name='getRootCauseStackTrace' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("getRootCauseStackTrace", "(Ljava/lang/Throwable;)[Ljava/lang/String;", "")]
		public static unsafe string[] GetRootCauseStackTrace (global::Java.Lang.Throwable throwable)
		{
			if (id_getRootCauseStackTrace_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_getRootCauseStackTrace_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "getRootCauseStackTrace", "(Ljava/lang/Throwable;)[Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (throwable);
				string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getRootCauseStackTrace_Ljava_lang_Throwable_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getStackFrames_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.exception']/class[@name='ExceptionUtils']/method[@name='getStackFrames' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("getStackFrames", "(Ljava/lang/Throwable;)[Ljava/lang/String;", "")]
		public static unsafe string[] GetStackFrames (global::Java.Lang.Throwable throwable)
		{
			if (id_getStackFrames_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_getStackFrames_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "getStackFrames", "(Ljava/lang/Throwable;)[Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (throwable);
				string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getStackFrames_Ljava_lang_Throwable_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getStackTrace_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.exception']/class[@name='ExceptionUtils']/method[@name='getStackTrace' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("getStackTrace", "(Ljava/lang/Throwable;)Ljava/lang/String;", "")]
		public static unsafe string GetStackTrace (global::Java.Lang.Throwable throwable)
		{
			if (id_getStackTrace_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_getStackTrace_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "getStackTrace", "(Ljava/lang/Throwable;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (throwable);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getStackTrace_Ljava_lang_Throwable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getThrowableCount_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.exception']/class[@name='ExceptionUtils']/method[@name='getThrowableCount' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("getThrowableCount", "(Ljava/lang/Throwable;)I", "")]
		public static unsafe int GetThrowableCount (global::Java.Lang.Throwable throwable)
		{
			if (id_getThrowableCount_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_getThrowableCount_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "getThrowableCount", "(Ljava/lang/Throwable;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (throwable);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getThrowableCount_Ljava_lang_Throwable_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getThrowableList_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.exception']/class[@name='ExceptionUtils']/method[@name='getThrowableList' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("getThrowableList", "(Ljava/lang/Throwable;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Java.Lang.Throwable> GetThrowableList (global::Java.Lang.Throwable throwable)
		{
			if (id_getThrowableList_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_getThrowableList_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "getThrowableList", "(Ljava/lang/Throwable;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (throwable);
				global::System.Collections.Generic.IList<global::Java.Lang.Throwable> __ret = global::Android.Runtime.JavaList<global::Java.Lang.Throwable>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getThrowableList_Ljava_lang_Throwable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getThrowables_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.exception']/class[@name='ExceptionUtils']/method[@name='getThrowables' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("getThrowables", "(Ljava/lang/Throwable;)[Ljava/lang/Throwable;", "")]
		public static unsafe global::Java.Lang.Throwable[] GetThrowables (global::Java.Lang.Throwable throwable)
		{
			if (id_getThrowables_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_getThrowables_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "getThrowables", "(Ljava/lang/Throwable;)[Ljava/lang/Throwable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (throwable);
				global::Java.Lang.Throwable[] __ret = (global::Java.Lang.Throwable[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getThrowables_Ljava_lang_Throwable_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Throwable));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_hasCause_Ljava_lang_Throwable_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.exception']/class[@name='ExceptionUtils']/method[@name='hasCause' and count(parameter)=2 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.Class&lt;? extends java.lang.Throwable&gt;']]"
		[Register ("hasCause", "(Ljava/lang/Throwable;Ljava/lang/Class;)Z", "")]
		public static unsafe bool HasCause (global::Java.Lang.Throwable chain, global::Java.Lang.Class type)
		{
			if (id_hasCause_Ljava_lang_Throwable_Ljava_lang_Class_ == IntPtr.Zero)
				id_hasCause_Ljava_lang_Throwable_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "hasCause", "(Ljava/lang/Throwable;Ljava/lang/Class;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (chain);
				__args [1] = new JValue (type);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_hasCause_Ljava_lang_Throwable_Ljava_lang_Class_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_indexOfThrowable_Ljava_lang_Throwable_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.exception']/class[@name='ExceptionUtils']/method[@name='indexOfThrowable' and count(parameter)=2 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("indexOfThrowable", "(Ljava/lang/Throwable;Ljava/lang/Class;)I", "")]
		public static unsafe int IndexOfThrowable (global::Java.Lang.Throwable throwable, global::Java.Lang.Class clazz)
		{
			if (id_indexOfThrowable_Ljava_lang_Throwable_Ljava_lang_Class_ == IntPtr.Zero)
				id_indexOfThrowable_Ljava_lang_Throwable_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "indexOfThrowable", "(Ljava/lang/Throwable;Ljava/lang/Class;)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (throwable);
				__args [1] = new JValue (clazz);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_indexOfThrowable_Ljava_lang_Throwable_Ljava_lang_Class_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_indexOfThrowable_Ljava_lang_Throwable_Ljava_lang_Class_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.exception']/class[@name='ExceptionUtils']/method[@name='indexOfThrowable' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.Class&lt;?&gt;'] and parameter[3][@type='int']]"
		[Register ("indexOfThrowable", "(Ljava/lang/Throwable;Ljava/lang/Class;I)I", "")]
		public static unsafe int IndexOfThrowable (global::Java.Lang.Throwable throwable, global::Java.Lang.Class clazz, int fromIndex)
		{
			if (id_indexOfThrowable_Ljava_lang_Throwable_Ljava_lang_Class_I == IntPtr.Zero)
				id_indexOfThrowable_Ljava_lang_Throwable_Ljava_lang_Class_I = JNIEnv.GetStaticMethodID (class_ref, "indexOfThrowable", "(Ljava/lang/Throwable;Ljava/lang/Class;I)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (throwable);
				__args [1] = new JValue (clazz);
				__args [2] = new JValue (fromIndex);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_indexOfThrowable_Ljava_lang_Throwable_Ljava_lang_Class_I, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_indexOfType_Ljava_lang_Throwable_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.exception']/class[@name='ExceptionUtils']/method[@name='indexOfType' and count(parameter)=2 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("indexOfType", "(Ljava/lang/Throwable;Ljava/lang/Class;)I", "")]
		public static unsafe int IndexOfType (global::Java.Lang.Throwable throwable, global::Java.Lang.Class type)
		{
			if (id_indexOfType_Ljava_lang_Throwable_Ljava_lang_Class_ == IntPtr.Zero)
				id_indexOfType_Ljava_lang_Throwable_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "indexOfType", "(Ljava/lang/Throwable;Ljava/lang/Class;)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (throwable);
				__args [1] = new JValue (type);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_indexOfType_Ljava_lang_Throwable_Ljava_lang_Class_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_indexOfType_Ljava_lang_Throwable_Ljava_lang_Class_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.exception']/class[@name='ExceptionUtils']/method[@name='indexOfType' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.Class&lt;?&gt;'] and parameter[3][@type='int']]"
		[Register ("indexOfType", "(Ljava/lang/Throwable;Ljava/lang/Class;I)I", "")]
		public static unsafe int IndexOfType (global::Java.Lang.Throwable throwable, global::Java.Lang.Class type, int fromIndex)
		{
			if (id_indexOfType_Ljava_lang_Throwable_Ljava_lang_Class_I == IntPtr.Zero)
				id_indexOfType_Ljava_lang_Throwable_Ljava_lang_Class_I = JNIEnv.GetStaticMethodID (class_ref, "indexOfType", "(Ljava/lang/Throwable;Ljava/lang/Class;I)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (throwable);
				__args [1] = new JValue (type);
				__args [2] = new JValue (fromIndex);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_indexOfType_Ljava_lang_Throwable_Ljava_lang_Class_I, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_printRootCauseStackTrace_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.exception']/class[@name='ExceptionUtils']/method[@name='printRootCauseStackTrace' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("printRootCauseStackTrace", "(Ljava/lang/Throwable;)V", "")]
		public static unsafe void PrintRootCauseStackTrace (global::Java.Lang.Throwable throwable)
		{
			if (id_printRootCauseStackTrace_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_printRootCauseStackTrace_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "printRootCauseStackTrace", "(Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (throwable);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_printRootCauseStackTrace_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

		static IntPtr id_printRootCauseStackTrace_Ljava_lang_Throwable_Ljava_io_PrintStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.exception']/class[@name='ExceptionUtils']/method[@name='printRootCauseStackTrace' and count(parameter)=2 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.io.PrintStream']]"
		[Register ("printRootCauseStackTrace", "(Ljava/lang/Throwable;Ljava/io/PrintStream;)V", "")]
		public static unsafe void PrintRootCauseStackTrace (global::Java.Lang.Throwable throwable, global::Java.IO.PrintStream stream)
		{
			if (id_printRootCauseStackTrace_Ljava_lang_Throwable_Ljava_io_PrintStream_ == IntPtr.Zero)
				id_printRootCauseStackTrace_Ljava_lang_Throwable_Ljava_io_PrintStream_ = JNIEnv.GetStaticMethodID (class_ref, "printRootCauseStackTrace", "(Ljava/lang/Throwable;Ljava/io/PrintStream;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (throwable);
				__args [1] = new JValue (stream);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_printRootCauseStackTrace_Ljava_lang_Throwable_Ljava_io_PrintStream_, __args);
			} finally {
			}
		}

		static IntPtr id_printRootCauseStackTrace_Ljava_lang_Throwable_Ljava_io_PrintWriter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.exception']/class[@name='ExceptionUtils']/method[@name='printRootCauseStackTrace' and count(parameter)=2 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.io.PrintWriter']]"
		[Register ("printRootCauseStackTrace", "(Ljava/lang/Throwable;Ljava/io/PrintWriter;)V", "")]
		public static unsafe void PrintRootCauseStackTrace (global::Java.Lang.Throwable throwable, global::Java.IO.PrintWriter writer)
		{
			if (id_printRootCauseStackTrace_Ljava_lang_Throwable_Ljava_io_PrintWriter_ == IntPtr.Zero)
				id_printRootCauseStackTrace_Ljava_lang_Throwable_Ljava_io_PrintWriter_ = JNIEnv.GetStaticMethodID (class_ref, "printRootCauseStackTrace", "(Ljava/lang/Throwable;Ljava/io/PrintWriter;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (throwable);
				__args [1] = new JValue (writer);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_printRootCauseStackTrace_Ljava_lang_Throwable_Ljava_io_PrintWriter_, __args);
			} finally {
			}
		}

		static IntPtr id_removeCommonFrames_Ljava_util_List_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.exception']/class[@name='ExceptionUtils']/method[@name='removeCommonFrames' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("removeCommonFrames", "(Ljava/util/List;Ljava/util/List;)V", "")]
		public static unsafe void RemoveCommonFrames (global::System.Collections.Generic.IList<string> causeFrames, global::System.Collections.Generic.IList<string> wrapperFrames)
		{
			if (id_removeCommonFrames_Ljava_util_List_Ljava_util_List_ == IntPtr.Zero)
				id_removeCommonFrames_Ljava_util_List_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "removeCommonFrames", "(Ljava/util/List;Ljava/util/List;)V");
			IntPtr native_causeFrames = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (causeFrames);
			IntPtr native_wrapperFrames = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (wrapperFrames);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_causeFrames);
				__args [1] = new JValue (native_wrapperFrames);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_removeCommonFrames_Ljava_util_List_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_causeFrames);
				JNIEnv.DeleteLocalRef (native_wrapperFrames);
			}
		}

		static IntPtr id_rethrow_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.exception']/class[@name='ExceptionUtils']/method[@name='rethrow' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("rethrow", "(Ljava/lang/Throwable;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public static unsafe global::Java.Lang.Object Rethrow (global::Java.Lang.Throwable throwable)
		{
			if (id_rethrow_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_rethrow_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "rethrow", "(Ljava/lang/Throwable;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (throwable);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_rethrow_Ljava_lang_Throwable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_wrapAndThrow_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.exception']/class[@name='ExceptionUtils']/method[@name='wrapAndThrow' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("wrapAndThrow", "(Ljava/lang/Throwable;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public static unsafe global::Java.Lang.Object WrapAndThrow (global::Java.Lang.Throwable throwable)
		{
			if (id_wrapAndThrow_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_wrapAndThrow_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "wrapAndThrow", "(Ljava/lang/Throwable;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (throwable);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_wrapAndThrow_Ljava_lang_Throwable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
