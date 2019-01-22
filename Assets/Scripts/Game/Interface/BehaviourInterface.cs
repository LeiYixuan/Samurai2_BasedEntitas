

namespace Game
{
    /// <summary>
    /// ������Ϊ�ӿ�
    /// </summary>
    public interface IBehaviour
    {
        void Idle();
        void Forward();
        void Back();
        void Left();
        void Right();
    }

    /// <summary>
    /// �����Ϊ�ӿ�
    /// </summary>
    public interface IPlayerBehaviour : IBehaviour
    {
        /// <summary>
        /// ��ǰ�Ƿ����ܱ�־λ
        /// </summary>
        bool IsRun { get; set; }

        /// <summary>
        /// ������������K��
        /// </summary>
        void AttackO();
        /// <summary>
        /// ������ ������L��
        /// </summary>
        void AttackX();
    }
}