public class Presenter_Health : IPresenter
{

    private Model_Health model_Health;
    private View_Health view_Health;

    public Presenter_Health(Model_Health model_Health, View_Health view_Health)
    {

        this.model_Health = model_Health;
        this.view_Health = view_Health;

    }

    public void Present()
    {
        view_Health.UpdateHealthBar(model_Health.health, model_Health.maxHealth);
    }

}
