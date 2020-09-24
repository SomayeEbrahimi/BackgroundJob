using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FI.Firstbeat.Ete {

	// Metadata.xml XPath class reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='FBTexercise']"
	[global::Android.Runtime.Register ("fi/firstbeat/ete/FBTexercise", DoNotGenerateAcw=true)]
	public partial class FBTexercise : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='FBTexercise']/field[@name='TE']"
		[Register ("TE")]
		public int Te {
			get {
				const string __id = "TE.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "TE.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='FBTexercise']/field[@name='coolTime']"
		[Register ("coolTime")]
		public int CoolTime {
			get {
				const string __id = "coolTime.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "coolTime.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='FBTexercise']/field[@name='distance']"
		[Register ("distance")]
		public int Distance {
			get {
				const string __id = "distance.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "distance.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='FBTexercise']/field[@name='repeats']"
		[Register ("repeats")]
		public int Repeats {
			get {
				const string __id = "repeats.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "repeats.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='FBTexercise']/field[@name='restTime']"
		[Register ("restTime")]
		public int RestTime {
			get {
				const string __id = "restTime.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "restTime.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='FBTexercise']/field[@name='warmupTime']"
		[Register ("warmupTime")]
		public int WarmupTime {
			get {
				const string __id = "warmupTime.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "warmupTime.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='FBTexercise']/field[@name='workTime']"
		[Register ("workTime")]
		public int WorkTime {
			get {
				const string __id = "workTime.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "workTime.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("fi/firstbeat/ete/FBTexercise", typeof (FBTexercise));
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

		protected FBTexercise (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='FBTexercise']/constructor[@name='FBTexercise' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FBTexercise ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

	}
}
