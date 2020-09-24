using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/FileUtils", DoNotGenerateAcw=true)]
	public partial class FileUtils : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/field[@name='FILE_EXTENSION_SEPARATOR']"
		[Register ("FILE_EXTENSION_SEPARATOR")]
		public const string FileExtensionSeparator = (string) ".";
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/utils/FileUtils", typeof (FileUtils));
		internal static IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected FileUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe long DiskAvailableSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='getDiskAvailableSize' and count(parameter)=0]"
			[Register ("getDiskAvailableSize", "()J", "")]
			get {
				const string __id = "getDiskAvailableSize.()J";
				try {
					var __rm = _members.StaticMethods.InvokeInt64Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsDiskSpaceAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='isDiskSpaceAvailable' and count(parameter)=0]"
			[Register ("isDiskSpaceAvailable", "()Z", "")]
			get {
				const string __id = "isDiskSpaceAvailable.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsExternalStorageReadable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='isExternalStorageReadable' and count(parameter)=0]"
			[Register ("isExternalStorageReadable", "()Z", "")]
			get {
				const string __id = "isExternalStorageReadable.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsExternalStorageWritable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='isExternalStorageWritable' and count(parameter)=0]"
			[Register ("isExternalStorageWritable", "()Z", "")]
			get {
				const string __id = "isExternalStorageWritable.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsSDCardAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='isSDCardAvailable' and count(parameter)=0]"
			[Register ("isSDCardAvailable", "()Z", "")]
			get {
				const string __id = "isSDCardAvailable.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='copy' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.lang.String']]"
		[Register ("copy", "(Ljava/io/InputStream;Ljava/lang/String;)Z", "")]
		public static unsafe bool Copy (global::System.IO.Stream @in, string toPath)
		{
			const string __id = "copy.(Ljava/io/InputStream;Ljava/lang/String;)Z";
			IntPtr native__in = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@in);
			IntPtr native_toPath = JNIEnv.NewString (toPath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native__in);
				__args [1] = new JniArgumentValue (native_toPath);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native__in);
				JNIEnv.DeleteLocalRef (native_toPath);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='copy' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("copy", "(Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public static unsafe bool Copy (string fromPath, string toPath)
		{
			const string __id = "copy.(Ljava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_fromPath = JNIEnv.NewString (fromPath);
			IntPtr native_toPath = JNIEnv.NewString (toPath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_fromPath);
				__args [1] = new JniArgumentValue (native_toPath);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_fromPath);
				JNIEnv.DeleteLocalRef (native_toPath);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='copyFile' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("copyFile", "(Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public static unsafe bool CopyFile (string sourceFilePath, string destFilePath)
		{
			const string __id = "copyFile.(Ljava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_sourceFilePath = JNIEnv.NewString (sourceFilePath);
			IntPtr native_destFilePath = JNIEnv.NewString (destFilePath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_sourceFilePath);
				__args [1] = new JniArgumentValue (native_destFilePath);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_sourceFilePath);
				JNIEnv.DeleteLocalRef (native_destFilePath);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='deleteFile' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("deleteFile", "(Ljava/io/File;)Z", "")]
		public static unsafe bool DeleteFile (global::Java.IO.File file)
		{
			const string __id = "deleteFile.(Ljava/io/File;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='deleteFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteFile", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool DeleteFile (string path)
		{
			const string __id = "deleteFile.(Ljava/lang/String;)Z";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_path);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='getDataDir' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getDataDir", "(Landroid/content/Context;)Ljava/io/File;", "")]
		public static unsafe global::Java.IO.File GetDataDir (global::Android.Content.Context context)
		{
			const string __id = "getDataDir.(Landroid/content/Context;)Ljava/io/File;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='getFileExtension' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFileExtension", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetFileExtension (string filePath)
		{
			const string __id = "getFileExtension.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_filePath);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='getFileName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFileName", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetFileName (string filePath)
		{
			const string __id = "getFileName.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_filePath);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='getFileNameWithoutExtension' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFileNameWithoutExtension", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetFileNameWithoutExtension (string filePath)
		{
			const string __id = "getFileNameWithoutExtension.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_filePath);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='getFileOrDirSize' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("getFileOrDirSize", "(Ljava/io/File;)J", "")]
		public static unsafe long GetFileOrDirSize (global::Java.IO.File file)
		{
			const string __id = "getFileOrDirSize.(Ljava/io/File;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='getFileSize' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFileSize", "(Ljava/lang/String;)J", "")]
		public static unsafe long GetFileSize (string path)
		{
			const string __id = "getFileSize.(Ljava/lang/String;)J";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_path);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='getFolderName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFolderName", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetFolderName (string filePath)
		{
			const string __id = "getFolderName.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_filePath);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='hasSDCardPermission' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("hasSDCardPermission", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool HasSDCardPermission (global::Android.Content.Context context)
		{
			const string __id = "hasSDCardPermission.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='isFileExist' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isFileExist", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsFileExist (string filePath)
		{
			const string __id = "isFileExist.(Ljava/lang/String;)Z";
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_filePath);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='isFolderExist' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isFolderExist", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsFolderExist (string directoryPath)
		{
			const string __id = "isFolderExist.(Ljava/lang/String;)Z";
			IntPtr native_directoryPath = JNIEnv.NewString (directoryPath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_directoryPath);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_directoryPath);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='makeDirs' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("makeDirs", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool MakeDirs (string filePath)
		{
			const string __id = "makeDirs.(Ljava/lang/String;)Z";
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_filePath);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='makeFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("makeFile", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool MakeFile (string filePath)
		{
			const string __id = "makeFile.(Ljava/lang/String;)Z";
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_filePath);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='makeFolders' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("makeFolders", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool MakeFolders (string filePath)
		{
			const string __id = "makeFolders.(Ljava/lang/String;)Z";
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_filePath);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='moveFile' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.io.File']]"
		[Register ("moveFile", "(Ljava/io/File;Ljava/io/File;)V", "")]
		public static unsafe void MoveFile (global::Java.IO.File srcFile, global::Java.IO.File destFile)
		{
			const string __id = "moveFile.(Ljava/io/File;Ljava/io/File;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((srcFile == null) ? IntPtr.Zero : ((global::Java.Lang.Object) srcFile).Handle);
				__args [1] = new JniArgumentValue ((destFile == null) ? IntPtr.Zero : ((global::Java.Lang.Object) destFile).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='moveFile' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("moveFile", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void MoveFile (string sourceFilePath, string destFilePath)
		{
			const string __id = "moveFile.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_sourceFilePath = JNIEnv.NewString (sourceFilePath);
			IntPtr native_destFilePath = JNIEnv.NewString (destFilePath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_sourceFilePath);
				__args [1] = new JniArgumentValue (native_destFilePath);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_sourceFilePath);
				JNIEnv.DeleteLocalRef (native_destFilePath);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='readFile' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("readFile", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/StringBuilder;", "")]
		public static unsafe global::Java.Lang.StringBuilder ReadFile (string filePath, string charsetName)
		{
			const string __id = "readFile.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/StringBuilder;";
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			IntPtr native_charsetName = JNIEnv.NewString (charsetName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_filePath);
				__args [1] = new JniArgumentValue (native_charsetName);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
				JNIEnv.DeleteLocalRef (native_charsetName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='readFileToList' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("readFileToList", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<string> ReadFileToList (string filePath, string charsetName)
		{
			const string __id = "readFileToList.(Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;";
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			IntPtr native_charsetName = JNIEnv.NewString (charsetName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_filePath);
				__args [1] = new JniArgumentValue (native_charsetName);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
				JNIEnv.DeleteLocalRef (native_charsetName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='readToString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("readToString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ReadToString (string filePath, string charset)
		{
			const string __id = "readToString.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			IntPtr native_charset = JNIEnv.NewString (charset);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_filePath);
				__args [1] = new JniArgumentValue (native_charset);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
				JNIEnv.DeleteLocalRef (native_charset);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='writeFile' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.io.InputStream']]"
		[Register ("writeFile", "(Ljava/io/File;Ljava/io/InputStream;)Z", "")]
		public static unsafe bool WriteFile (global::Java.IO.File file, global::System.IO.Stream stream)
		{
			const string __id = "writeFile.(Ljava/io/File;Ljava/io/InputStream;)Z";
			IntPtr native_stream = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (stream);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				__args [1] = new JniArgumentValue (native_stream);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_stream);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='writeFile' and count(parameter)=3 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.io.InputStream'] and parameter[3][@type='boolean']]"
		[Register ("writeFile", "(Ljava/io/File;Ljava/io/InputStream;Z)Z", "")]
		public static unsafe bool WriteFile (global::Java.IO.File file, global::System.IO.Stream stream, bool append)
		{
			const string __id = "writeFile.(Ljava/io/File;Ljava/io/InputStream;Z)Z";
			IntPtr native_stream = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (stream);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				__args [1] = new JniArgumentValue (native_stream);
				__args [2] = new JniArgumentValue (append);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_stream);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='writeFile' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.io.InputStream']]"
		[Register ("writeFile", "(Ljava/lang/String;Ljava/io/InputStream;)Z", "")]
		public static unsafe bool WriteFile (string filePath, global::System.IO.Stream stream)
		{
			const string __id = "writeFile.(Ljava/lang/String;Ljava/io/InputStream;)Z";
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			IntPtr native_stream = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (stream);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_filePath);
				__args [1] = new JniArgumentValue (native_stream);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
				JNIEnv.DeleteLocalRef (native_stream);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='writeFile' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.io.InputStream'] and parameter[3][@type='boolean']]"
		[Register ("writeFile", "(Ljava/lang/String;Ljava/io/InputStream;Z)Z", "")]
		public static unsafe bool WriteFile (string filePath, global::System.IO.Stream stream, bool append)
		{
			const string __id = "writeFile.(Ljava/lang/String;Ljava/io/InputStream;Z)Z";
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			IntPtr native_stream = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (stream);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_filePath);
				__args [1] = new JniArgumentValue (native_stream);
				__args [2] = new JniArgumentValue (append);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
				JNIEnv.DeleteLocalRef (native_stream);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='writeFile' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("writeFile", "(Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public static unsafe bool WriteFile (string filePath, string content)
		{
			const string __id = "writeFile.(Ljava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			IntPtr native_content = JNIEnv.NewString (content);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_filePath);
				__args [1] = new JniArgumentValue (native_content);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
				JNIEnv.DeleteLocalRef (native_content);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='writeFile' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("writeFile", "(Ljava/lang/String;Ljava/lang/String;Z)Z", "")]
		public static unsafe bool WriteFile (string filePath, string content, bool append)
		{
			const string __id = "writeFile.(Ljava/lang/String;Ljava/lang/String;Z)Z";
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			IntPtr native_content = JNIEnv.NewString (content);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_filePath);
				__args [1] = new JniArgumentValue (native_content);
				__args [2] = new JniArgumentValue (append);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
				JNIEnv.DeleteLocalRef (native_content);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='writeFile' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("writeFile", "(Ljava/lang/String;Ljava/util/List;)Z", "")]
		public static unsafe bool WriteFile (string filePath, global::System.Collections.Generic.IList<string> contentList)
		{
			const string __id = "writeFile.(Ljava/lang/String;Ljava/util/List;)Z";
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			IntPtr native_contentList = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (contentList);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_filePath);
				__args [1] = new JniArgumentValue (native_contentList);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
				JNIEnv.DeleteLocalRef (native_contentList);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='FileUtils']/method[@name='writeFile' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[3][@type='boolean']]"
		[Register ("writeFile", "(Ljava/lang/String;Ljava/util/List;Z)Z", "")]
		public static unsafe bool WriteFile (string filePath, global::System.Collections.Generic.IList<string> contentList, bool append)
		{
			const string __id = "writeFile.(Ljava/lang/String;Ljava/util/List;Z)Z";
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			IntPtr native_contentList = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (contentList);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_filePath);
				__args [1] = new JniArgumentValue (native_contentList);
				__args [2] = new JniArgumentValue (append);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
				JNIEnv.DeleteLocalRef (native_contentList);
			}
		}

	}
}
