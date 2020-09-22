using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3.Internal.Cache {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='DiskLruCache']"
	[global::Android.Runtime.Register ("okhttp3/internal/cache/DiskLruCache", DoNotGenerateAcw=true)]
	public sealed partial class DiskLruCache : global::Java.Lang.Object, global::Java.IO.ICloseable, global::Java.IO.IFlushable {

		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='DiskLruCache.Editor']"
		[global::Android.Runtime.Register ("okhttp3/internal/cache/DiskLruCache$Editor", DoNotGenerateAcw=true)]
		public sealed partial class Editor : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("okhttp3/internal/cache/DiskLruCache$Editor", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Editor); }
			}

			internal Editor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_abort;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='DiskLruCache.Editor']/method[@name='abort' and count(parameter)=0]"
			[Register ("abort", "()V", "")]
			public unsafe void Abort ()
			{
				if (id_abort == IntPtr.Zero)
					id_abort = JNIEnv.GetMethodID (class_ref, "abort", "()V");
				try {
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_abort);
				} finally {
				}
			}

			static IntPtr id_abortUnlessCommitted;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='DiskLruCache.Editor']/method[@name='abortUnlessCommitted' and count(parameter)=0]"
			[Register ("abortUnlessCommitted", "()V", "")]
			public unsafe void AbortUnlessCommitted ()
			{
				if (id_abortUnlessCommitted == IntPtr.Zero)
					id_abortUnlessCommitted = JNIEnv.GetMethodID (class_ref, "abortUnlessCommitted", "()V");
				try {
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_abortUnlessCommitted);
				} finally {
				}
			}

			static IntPtr id_commit;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='DiskLruCache.Editor']/method[@name='commit' and count(parameter)=0]"
			[Register ("commit", "()V", "")]
			public unsafe void Commit ()
			{
				if (id_commit == IntPtr.Zero)
					id_commit = JNIEnv.GetMethodID (class_ref, "commit", "()V");
				try {
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_commit);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='DiskLruCache.Snapshot']"
		[global::Android.Runtime.Register ("okhttp3/internal/cache/DiskLruCache$Snapshot", DoNotGenerateAcw=true)]
		public sealed partial class Snapshot : global::Java.Lang.Object, global::Java.IO.ICloseable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("okhttp3/internal/cache/DiskLruCache$Snapshot", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Snapshot); }
			}

			internal Snapshot (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_close;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='DiskLruCache.Snapshot']/method[@name='close' and count(parameter)=0]"
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

			static IntPtr id_edit;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='DiskLruCache.Snapshot']/method[@name='edit' and count(parameter)=0]"
			[Register ("edit", "()Lokhttp3/internal/cache/DiskLruCache$Editor;", "")]
			public unsafe global::Okhttp3.Internal.Cache.DiskLruCache.Editor Edit ()
			{
				if (id_edit == IntPtr.Zero)
					id_edit = JNIEnv.GetMethodID (class_ref, "edit", "()Lokhttp3/internal/cache/DiskLruCache$Editor;");
				try {
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Cache.DiskLruCache.Editor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_edit), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_getLength_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='DiskLruCache.Snapshot']/method[@name='getLength' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getLength", "(I)J", "")]
			public unsafe long GetLength (int index)
			{
				if (id_getLength_I == IntPtr.Zero)
					id_getLength_I = JNIEnv.GetMethodID (class_ref, "getLength", "(I)J");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (index);
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getLength_I, __args);
				} finally {
				}
			}

			static IntPtr id_key;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='DiskLruCache.Snapshot']/method[@name='key' and count(parameter)=0]"
			[Register ("key", "()Ljava/lang/String;", "")]
			public unsafe string Key ()
			{
				if (id_key == IntPtr.Zero)
					id_key = JNIEnv.GetMethodID (class_ref, "key", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_key), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/internal/cache/DiskLruCache", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DiskLruCache); }
		}

		internal DiskLruCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getDirectory;
		public unsafe global::Java.IO.File Directory {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='DiskLruCache']/method[@name='getDirectory' and count(parameter)=0]"
			[Register ("getDirectory", "()Ljava/io/File;", "")]
			get {
				if (id_getDirectory == IntPtr.Zero)
					id_getDirectory = JNIEnv.GetMethodID (class_ref, "getDirectory", "()Ljava/io/File;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDirectory), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_isClosed;
		public unsafe bool IsClosed {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='DiskLruCache']/method[@name='isClosed' and count(parameter)=0]"
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

		static IntPtr id_getMaxSize;
		static IntPtr id_setMaxSize_J;
		public unsafe long MaxSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='DiskLruCache']/method[@name='getMaxSize' and count(parameter)=0]"
			[Register ("getMaxSize", "()J", "")]
			get {
				if (id_getMaxSize == IntPtr.Zero)
					id_getMaxSize = JNIEnv.GetMethodID (class_ref, "getMaxSize", "()J");
				try {
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getMaxSize);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='DiskLruCache']/method[@name='setMaxSize' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setMaxSize", "(J)V", "")]
			set {
				if (id_setMaxSize_J == IntPtr.Zero)
					id_setMaxSize_J = JNIEnv.GetMethodID (class_ref, "setMaxSize", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMaxSize_J, __args);
				} finally {
				}
			}
		}

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='DiskLruCache']/method[@name='close' and count(parameter)=0]"
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

		static IntPtr id_create_Lokhttp3_internal_io_FileSystem_Ljava_io_File_IIJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='DiskLruCache']/method[@name='create' and count(parameter)=5 and parameter[1][@type='okhttp3.internal.io.FileSystem'] and parameter[2][@type='java.io.File'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='long']]"
		[Register ("create", "(Lokhttp3/internal/io/FileSystem;Ljava/io/File;IIJ)Lokhttp3/internal/cache/DiskLruCache;", "")]
		public static unsafe global::Okhttp3.Internal.Cache.DiskLruCache Create (global::Okhttp3.Internal.IO.IFileSystem fileSystem, global::Java.IO.File directory, int appVersion, int valueCount, long maxSize)
		{
			if (id_create_Lokhttp3_internal_io_FileSystem_Ljava_io_File_IIJ == IntPtr.Zero)
				id_create_Lokhttp3_internal_io_FileSystem_Ljava_io_File_IIJ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Lokhttp3/internal/io/FileSystem;Ljava/io/File;IIJ)Lokhttp3/internal/cache/DiskLruCache;");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (fileSystem);
				__args [1] = new JValue (directory);
				__args [2] = new JValue (appVersion);
				__args [3] = new JValue (valueCount);
				__args [4] = new JValue (maxSize);
				global::Okhttp3.Internal.Cache.DiskLruCache __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Cache.DiskLruCache> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Lokhttp3_internal_io_FileSystem_Ljava_io_File_IIJ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_delete;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='DiskLruCache']/method[@name='delete' and count(parameter)=0]"
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

		static IntPtr id_edit_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='DiskLruCache']/method[@name='edit' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("edit", "(Ljava/lang/String;)Lokhttp3/internal/cache/DiskLruCache$Editor;", "")]
		public unsafe global::Okhttp3.Internal.Cache.DiskLruCache.Editor Edit (string key)
		{
			if (id_edit_Ljava_lang_String_ == IntPtr.Zero)
				id_edit_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "edit", "(Ljava/lang/String;)Lokhttp3/internal/cache/DiskLruCache$Editor;");
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_key);
				global::Okhttp3.Internal.Cache.DiskLruCache.Editor __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Cache.DiskLruCache.Editor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_edit_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static IntPtr id_evictAll;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='DiskLruCache']/method[@name='evictAll' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='DiskLruCache']/method[@name='flush' and count(parameter)=0]"
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

		static IntPtr id_get_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='DiskLruCache']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Lokhttp3/internal/cache/DiskLruCache$Snapshot;", "")]
		public unsafe global::Okhttp3.Internal.Cache.DiskLruCache.Snapshot Get (string key)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;)Lokhttp3/internal/cache/DiskLruCache$Snapshot;");
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_key);
				global::Okhttp3.Internal.Cache.DiskLruCache.Snapshot __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Cache.DiskLruCache.Snapshot> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static IntPtr id_initialize;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='DiskLruCache']/method[@name='initialize' and count(parameter)=0]"
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

		static IntPtr id_remove_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='DiskLruCache']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("remove", "(Ljava/lang/String;)Z", "")]
		public unsafe bool Remove (string key)
		{
			if (id_remove_Ljava_lang_String_ == IntPtr.Zero)
				id_remove_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/String;)Z");
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_key);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_remove_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='DiskLruCache']/method[@name='size' and count(parameter)=0]"
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

		static IntPtr id_snapshots;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.cache']/class[@name='DiskLruCache']/method[@name='snapshots' and count(parameter)=0]"
		[Register ("snapshots", "()Ljava/util/Iterator;", "")]
		public unsafe global::Java.Util.IIterator Snapshots ()
		{
			if (id_snapshots == IntPtr.Zero)
				id_snapshots = JNIEnv.GetMethodID (class_ref, "snapshots", "()Ljava/util/Iterator;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_snapshots), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
