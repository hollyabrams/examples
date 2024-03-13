package example

import (
	"fmt"

	"github.com/EasyPost/easypost-go/v3"
)

func main() {
	client := easypost.New("EASYPOST_API_KEY")

	// Retrieve all API keys including children
	apiKeys, _ := client.GetAPIKeys()

	fmt.Println(apiKeys)

	// Retrieve API keys for a specific child user
	childApiKeys, _ := client.GetAPIKeysForUser("user_...")

	fmt.Println(childApiKeys)
}
