// New Relic Browser monitoring script for real user monitoring (RUM) and custom attributes for WTH Jeopardy game
// Copy and paste the code from your New Relic Browser monitoring script here, and ensure that the 'newrelic' object is available for use in your application

// Record the team name and score as custom attributes in New Relic for better insights into user interactions and game performance
function RecordTeamScore(team, score) {
    newrelic.setCustomAttribute('WTHJeopardyTeam', team);
    newrelic.setCustomAttribute('WTHJeopardyTeamScore', score);
}