package example

import (
	"github.com/EasyPost/easypost-go/v5"
)

func update() {
	client := easypost.New("EASYPOST_API_KEY")

	_, _ = client.UpdateReferralCustomerEmail("user_...", "new_email@example.com")
}
