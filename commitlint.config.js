module.exports = {
    extends: ['@commitlint/config-conventional'],
    rules: {
        "scope-enum": _ => [
            2,
            "always",
            [
                "deps",
                "core",
                "auto-fixture",
                "background",
                "bogus",
                "function-app",
                "hedgehog",
                "http",
                "logging",
                "verify-nunit",
                "verify-xunit",
            ]
        ]
    }
}
