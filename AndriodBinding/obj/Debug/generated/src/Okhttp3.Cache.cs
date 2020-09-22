using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='Cache']"
	[global::Android.Runtime.Register ("okhttp3/Cache", DoNotGenerateAcw=true)]
	public sealed partial class Cache : global::Java.Lang.Object, global::Java.IO.ICloseable, global::Java.IO.IFlushable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/Cache", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Cache); }
		}

		internal Cache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_File_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='Cache']/constructor[@name='Cache' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='long']]"
		[Register (".ctor", "(Ljava/io/File;J)V", "")]
		public unsafe Cache (global::Java.IO.File directory, long maxSize)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (directory);
				__args [1] = new JValue (maxSize);
				if (((object) this).GetType () != typeof (Cache)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/io/File;J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/io/File;J)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_File_J == IntPtr.Zero)
					id_ctor_Ljava_io_File_J = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/File;J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_File_J, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_io_File_J, __args);
			} finally {
			}
		}

		static IntPtr id_isClosed;
		public unsafe bool IsClosed {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cache']/method[@name='isClosed' and count(parameter)=0]"
			[Register ("isClosed", "()Z", "")]
			get {
				if (id_isClosed == IntPtr.Zero)
					id_isClosed = JNIEnv.GetMethodID (class_ref, "isClosed", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isClosed);
				} finally {
				}
			}
		}

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cache']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "")]
		public unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
			} finally {
			}
		}

		static IntPtr id_delete;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cache']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "")]
		public unsafe void Delete ()
		{
			if (id_delete == IntPtr.Zero)
				id_delete = JNIEnv.GetMethodID (class_ref, "delete", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_delete);
			} finally {
			}
		}

		static IntPtr id_directory;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cache']/method[@name='directory' and count(parameter)=0]"
		[Register ("directory", "()Ljava/io/File;", "")]
		public unsafe global::Java.IO.File Directory ()
		{
			if (id_directory == IntPtr.Zero)
				id_directory = JNIEnv.GetMethodID (class_ref, "directory", "()Ljava/io/File;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_directory), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_evictAll;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cache']/method[@name='evictAll' and count(parameter)=0]"
		[Register ("evictAll", "()V", "")]
		public unsafe void EvictAll ()
		{
			if (id_evictAll == IntPtr.Zero)
				id_evictAll = JNIEnv.GetMethodID (class_ref, "evictAll", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_evictAll);
			} finally {
			}
		}

		static IntPtr id_flush;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cache']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "")]
		public unsafe void Flush ()
		{
			if (id_flush == IntPtr.Zero)
				id_flush = JNIEnv.GetMethodID (class_ref, "flush", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_flush);
			} finally {
			}
		}

		static IntPtr id_hitCount;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cache']/method[@name='hitCount' and count(parameter)=0]"
		[Register ("hitCount", "()I", "")]
		public unsafe int HitCount ()
		{
			if (id_hitCount == IntPtr.Zero)
				id_hitCount = JNIEnv.GetMethodID (class_ref, "hitCount", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hitCount);
			} finally {
			}
		}

		static IntPtr id_initialize;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cache']/method[@name='initialize' and count(parameter)=0]"
		[Register ("initialize", "()V", "")]
		public unsafe void Initialize ()
		{
			if (id_initialize == IntPtr.Zero)
				id_initialize = JNIEnv.GetMethodID (class_ref, "initialize", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initialize);
			} finally {
			}
		}

		static IntPtr id_key_Lokhttp3_HttpUrl_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cache']/method[@name='key' and count(parameter)=1 and parameter[1][@type='okhttp3.HttpUrl']]"
		[Register ("key", "(Lokhttp3/HttpUrl;)Ljava/lang/String;", "")]
		public static unsafe string Key (global::Okhttp3.HttpUrl url)
		{
			if (id_key_Lokhttp3_HttpUrl_ == IntPtr.Zero)
				id_key_Lokhttp3_HttpUrl_ = JNIEnv.GetStaticMethodID (class_ref, "key", "(Lokhttp3/HttpUrl;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (url);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_key_Lokhttp3_HttpUrl_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_maxSize;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cache']/method[@name='maxSize' and count(parameter)=0]"
		[Register ("maxSize", "()J", "")]
		public unsafe long MaxSize ()
		{
			if (id_maxSize == IntPtr.Zero)
				id_maxSize = JNIEnv.GetMethodID (class_ref, "maxSize", "()J");
			try {
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_maxSize);
			} finally {
			}
		}

		static IntPtr id_networkCount;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cache']/method[@name='networkCount' and count(parameter)=0]"
		[Register ("networkCount", "()I", "")]
		public unsafe int NetworkCount ()
		{
			if (id_networkCount == IntPtr.Zero)
				id_networkCount = JNIEnv.GetMethodID (class_ref, "networkCount", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_networkCount);
			} finally {
			}
		}

		static IntPtr id_requestCount;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cache']/method[@name='requestCount' and count(parameter)=0]"
		[Register ("requestCount", "()I", "")]
		public unsafe int RequestCount ()
		{
			if (id_requestCount == IntPtr.Zero)
				id_requestCount = JNIEnv.GetMethodID (class_ref, "requestCount", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_requestCount);
			} finally {
			}
		}

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cache']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()J", "")]
		public unsafe long Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()J");
			try {
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_size);
			} finally {
			}
		}

		static IntPtr id_urls;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cache']/method[@name='urls' and count(parameter)=0]"
		[Register ("urls", "()Ljava/util/Iterator;", "")]
		public unsafe global::Java.Util.IIterator Urls ()
		{
			if (id_urls == IntPtr.Zero)
				id_urls = JNIEnv.GetMethodID (class_ref, "urls", "()Ljava/util/Iterator;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_urls), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_writeAbortCount;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cache']/method[@name='writeAbortCount' and count(parameter)=0]"
		[Register ("writeAbortCount", "()I", "")]
		public unsafe int WriteAbortCount ()
		{
			if (id_writeAbortCount == IntPtr.Zero)
				id_writeAbortCount = JNIEnv.GetMethodID (class_ref, "writeAbortCount", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_writeAbortCount);
			} finally {
			}
		}

		static IntPtr id_writeSuccessCount;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cache']/method[@name='writeSuccessCount' and count(parameter)=0]"
		[Register ("writeSuccessCount", "()I", "")]
		public unsafe int WriteSuccessCount ()
		{
			if (id_writeSuccessCount == IntPtr.Zero)
				id_writeSuccessCount = JNIEnv.GetMethodID (class_ref, "writeSuccessCount", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_writeSuccessCount);
			} finally {
			}
		}

	}
}
