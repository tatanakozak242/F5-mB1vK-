using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0x8cf2432b : MonoBehaviour
{
    private Vector3 _0xaf1d2f83 { get; set; }

    private float _0x633e5f06 = 1;
    private void _0xb04d1b4e()
    {
        float _0xb096e6b7, _0xcbb96515, _0xc2a22841, _0x4909056f;
        if (this._0xcd2f17ad == _0x885b6959.Landscape)
            this._0xf829a667.orthographicSize = 1f / this._0xf829a667.aspect * this._0x633e5f06 / 2f;
        else
            this._0xf829a667.orthographicSize = this._0x633e5f06 / 2f;
        this._0x79b4b472 = 2f * this._0xf829a667.orthographicSize;
        this._0xe036af83 = this._0x79b4b472 * this._0xf829a667.aspect;
        float _0xa45ce99d = this._0xf829a667.transform.position.x;
        float _0xc33e46ef = this._0xf829a667.transform.position.y;
        _0xb096e6b7 = _0xa45ce99d - this._0xe036af83 / 2;
        _0xcbb96515 = _0xa45ce99d + this._0xe036af83 / 2;
        _0xc2a22841 = _0xc33e46ef + this._0x79b4b472 / 2;
        _0x4909056f = _0xc33e46ef - this._0x79b4b472 / 2;
        this._0x1b66148a = new Vector3(_0xb096e6b7, _0x4909056f, 0);
        this._0x392457e5 = new Vector3(_0xa45ce99d, _0x4909056f, 0);
        this._0x2e8bdba1 = new Vector3(_0xcbb96515, _0x4909056f, 0);
        this._0xfcb2ca47 = new Vector3(_0xb096e6b7, _0xc33e46ef, 0);
        this._0xf8455383 = new Vector3(_0xa45ce99d, _0xc33e46ef, 0);
        this._0x13cb7d7a = new Vector3(_0xcbb96515, _0xc33e46ef, 0);
        this._0x6fc766ef = new Vector3(_0xb096e6b7, _0xc2a22841, 0);
        this._0xaf1d2f83 = new Vector3(_0xa45ce99d, _0xc2a22841, 0);
        this._0xf4f6c1a9 = new Vector3(_0xcbb96515, _0xc2a22841, 0);
    }

    private Vector3 _0x13cb7d7a { get; set; }
    //public bool executeInUpdate;
    private float _0xe036af83 { get; set; }

    private static _0x8cf2432b _0x3083427a;
    private void OnDrawGizmos()
    {
        Gizmos.color = this._0x51e8a7ef;
        Matrix4x4 _0xe0910a9d = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0xf829a667.orthographic)
        {
            float _0x04763c5e = this._0xf829a667.farClipPlane - this._0xf829a667.nearClipPlane;
            float _0xbd06f569 = (this._0xf829a667.farClipPlane + this._0xf829a667.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0xbd06f569), new Vector3(this._0xf829a667.orthographicSize * 2 * this._0xf829a667.aspect, this._0xf829a667.orthographicSize * 2, _0x04763c5e));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0xf829a667.fieldOfView, this._0xf829a667.farClipPlane, this._0xf829a667.nearClipPlane, this._0xf829a667.aspect);
        }

        Gizmos.matrix = _0xe0910a9d;
    }

    private Vector3 _0x392457e5 { get; set; }

    private Color _0x51e8a7ef = Color.white;
    private Vector3 _0xf8455383 { get; set; }

    private _0x885b6959 _0xcd2f17ad = _0x885b6959.Portrait;
    private void Awake()
    {
        this._0xf829a667 = this.GetComponent<Camera>();
        _0x3083427a = this;
        this._0xb04d1b4e();
    }

    private Vector3 _0x1b66148a { get; set; }
    private Vector3 _0x6fc766ef { get; set; }

    private new Camera _0xf829a667;
    public enum _0x885b6959
    {
        Landscape,
        Portrait
    }

    private float _0x79b4b472 { get; set; }
    private Vector3 _0x2e8bdba1 { get; set; }
    private Vector3 _0xfcb2ca47 { get; set; }
    private Vector3 _0xf4f6c1a9 { get; set; }
}