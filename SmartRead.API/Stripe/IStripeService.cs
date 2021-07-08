using SmartRead.Model;
using SmartRead.Model.Requests;
using System.Threading.Tasks;

namespace SmartRead.API.Stripe
{
    public interface IStripeService
    {
        Task<Uplata> KupiKredit(int id, UplataRequest request);
    }
}
