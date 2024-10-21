
using UnityEngine;

public class ChangeAnime : MonoBehaviour

{
    private bool _animBool;
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnValidate()
    {
        if (_animator != null)
        {
        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            _animBool = !_animBool; //toggle ( il faut faire juste l'inverse comme un interuptueur)
            _animator.SetBool("SwitchAnime", _animBool);

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _animator.SetTrigger("HitTrigger");
        }

        Move();


     
            
    }

    private void Move()
    {
        float z = Input.GetAxisRaw("Vertical");
        _animator.SetFloat("Speed",z);
    }


}

