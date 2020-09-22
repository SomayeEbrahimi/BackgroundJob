using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='IOUtils']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/IOUtils", DoNotGenerateAcw=true)]
	public partial class IOUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/utils/IOUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOUtils); }
		}

		protected IOUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_close_Ljava_io_Closeable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='IOUtils']/method[@name='close' and count(parameter)=1 and parameter[1][@type='java.io.Closeable']]"
		[Register ("close", "(Ljava/io/Closeable;)V", "")]
		public static unsafe void Close (global::Java.IO.ICloseable closeable)
		{
			if (id_close_Ljava_io_Closeable_ == IntPtr.Zero)
				id_close_Ljava_io_Closeable_ = JNIEnv.GetStaticMethodID (class_ref, "close", "(Ljava/io/Closeable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (closeable);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_close_Ljava_io_Closeable_, __args);
			} finally {
			}
		}

		static IntPtr id_closeQuietly_Ljava_io_Closeable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='IOUtils']/method[@name='closeQuietly' and count(parameter)=1 and parameter[1][@type='java.io.Closeable']]"
		[Register ("closeQuietly", "(Ljava/io/Closeable;)V", "")]
		public static unsafe void CloseQuietly (global::Java.IO.ICloseable closeable)
		{
			if (id_closeQuietly_Ljava_io_Closeable_ == IntPtr.Zero)
				id_closeQuietly_Ljava_io_Closeable_ = JNIEnv.GetStaticMethodID (class_ref, "closeQuietly", "(Ljava/io/Closeable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (closeable);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_closeQuietly_Ljava_io_Closeable_, __args);
			} finally {
			}
		}

		static IntPtr id_copy_Ljava_io_InputStream_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='IOUtils']/method[@name='copy' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.io.OutputStream']]"
		[Register ("copy", "(Ljava/io/InputStream;Ljava/io/OutputStream;)V", "")]
		public static unsafe void Copy (global::System.IO.Stream @in, global::System.IO.Stream @out)
		{
			if (id_copy_Ljava_io_InputStream_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_copy_Ljava_io_InputStream_Ljava_io_OutputStream_ = JNIEnv.GetStaticMethodID (class_ref, "copy", "(Ljava/io/InputStream;Ljava/io/OutputStream;)V");
			IntPtr native__in = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@in);
			IntPtr native__out = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (@out);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native__in);
				__args [1] = new JValue (native__out);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_copy_Ljava_io_InputStream_Ljava_io_OutputStream_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__in);
				JNIEnv.DeleteLocalRef (native__out);
			}
		}

		static IntPtr id_deleteFileOrDir_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='IOUtils']/method[@name='deleteFileOrDir' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("deleteFileOrDir", "(Ljava/io/File;)Z", "")]
		public static unsafe bool DeleteFileOrDir (global::Java.IO.File path)
		{
			if (id_deleteFileOrDir_Ljava_io_File_ == IntPtr.Zero)
				id_deleteFileOrDir_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "deleteFileOrDir", "(Ljava/io/File;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (path);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_deleteFileOrDir_Ljava_io_File_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
