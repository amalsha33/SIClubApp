package crc64f882b0f22d3e05ab;


public class XEditorRenderer
	extends crc643f46942d9dd1fff9.EditorRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Project.Droid.Helpers.XEditorRenderer, Project.Android", XEditorRenderer.class, __md_methods);
	}


	public XEditorRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == XEditorRenderer.class)
			mono.android.TypeManager.Activate ("Project.Droid.Helpers.XEditorRenderer, Project.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public XEditorRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == XEditorRenderer.class)
			mono.android.TypeManager.Activate ("Project.Droid.Helpers.XEditorRenderer, Project.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public XEditorRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == XEditorRenderer.class)
			mono.android.TypeManager.Activate ("Project.Droid.Helpers.XEditorRenderer, Project.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
