import com.easypost.EasyPost;

public class RetrieveParcel {
    public static void main(String[] args) {
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        Parcel parcel = Parcel.retrieve("prcl_...");

        System.out.println(parcel);
    }
}
